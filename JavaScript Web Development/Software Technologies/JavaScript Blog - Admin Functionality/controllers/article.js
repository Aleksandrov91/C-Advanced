const Article = require('mongoose').model('Article');

function isLoggedIn(req, res, id, func) {
    if (!req.isAuthenticated()) {
        let returnUrl = `/article/${func}/${id}`;
        req.session.returnUrl = returnUrl;

        res.redirect('/user/login');
        return;
    }
}

function validateArticles(req, articleArgs) {
    let errorMsg = '';
    if (!req.isAuthenticated()) {
        errorMsg = 'You should be logged in to operate with articles!'
    } else if (!articleArgs.title) {
        errorMsg = 'Invalid title!';
    } else if (!articleArgs.content) {
        errorMsg = 'Invalid content!';
    }
    return errorMsg;
}

module.exports = {
    createGet: (req, res) => {
        res.render('article/create');
    },

    createPost: (req, res) => {
        let articleArgs = req.body;

        let errorMsg = validateArticles(req, articleArgs);

        if (errorMsg) {
            res.render('article/create', {error: errorMsg});
            return;
        }

        articleArgs.author = req.user.id;
        Article.create(articleArgs).then(article => {
            req.user.articles.push(article.id);
            req.user.save(err => {
                if (err) {
                    res.redirect('/', {error: err.message});
                } else {
                    res.redirect('/');
                }
            })
        })
    },

    details: (req, res) => {
        let id = req.params.id;

        Article.findById(id).populate('author').then(article => {
            if(!req.user){
                res.render('article/details', {article: article, isUserAutorized: false});
                return;
            }

            req.user.isInRole('Admin').then(isAdmin => {
                let isUserAutorized = isAdmin || req.user.isAuthor(article);

                res.render('article/details', {article: article, isUserAutorized});
            })
        });
    },

    editGet: (req, res) => {
        let id = req.params.id;

        isLoggedIn(req, res, id, 'edit');

        Article.findById(id).then(article => {
            req.user.isInRole('Admin').then(isAdmin => {
                if(!isAdmin && !req.user.isAuthor(article)){
                    res.redirect('/');
                    return;
                }

                res.render('article/edit', article);
            })
        })


    },

    editPost: (req, res) => {
        let id = req.params.id;
        let articleArgs = req.body;

        let errorMsg = validateArticles(req, articleArgs);

        if (errorMsg) {
            res.render('article/edit', {error: errorMsg});
            return;
        }

        isLoggedIn(req, res, id, 'edit');

        Article.findById(id).then(article => {
            req.user.isInRole('Admin').then(isAdmin => {
                if (!isAdmin && !req.user.isAuthor(article)) {
                    res.redirect('/');
                    return;
                }

                Article.update({_id: id}, {$set: {title: articleArgs.title, content: articleArgs.content}})
                    .then(updateStatus => {
                        res.redirect(`/article/details/${id}`);
                    });
            });
        });
    },

    deleteGet: (req, res) => {
        let id = req.params.id;

        isLoggedIn(req, res, id, 'delete');

        Article.findById(id).then(article => {
            req.user.isInRole('Admin').then(isAdmin => {
                if (!isAdmin && !req.user.isAuthor(article)) {
                    res.redirect('/');
                    return;
                }

                res.render('article/delete', article);
            });
        })
    },

    deletePost: (req, res) => {
        let id = req.params.id;

        isLoggedIn(req, res, id, 'delete');

        Article.findById(id).then(article => {
            req.user.isInRole('Admin').then(isAdmin => {
                if (!isAdmin && !req.user.isAuthor(article)) {
                    res.redirect('/');
                    return;
                }

                Article.findOneAndRemove({_id: id}).populate('author').then(article => {
                    let author = article.author;

                    let index = author.articles.indexOf(article.id);

                    if (index < 0) {
                        let errorMsg = 'Article was not found for that author!';
                        res.render('article/delete', {error: errorMsg});
                        return;
                    }

                    author.articles.splice(index, 1);
                    author.save().then((user) => {
                        res.redirect('/');
                    });
                });
            });
        })
    },
};
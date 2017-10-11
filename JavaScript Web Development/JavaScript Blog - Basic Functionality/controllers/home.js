const mongoose = require('mongoose');
const Article = mongoose.model('Article');

module.exports = {
  index: (req, res) => {
      Article.find({}).sort({date: 'desc'}).populate('author').limit(6).then(articles => {
          articles.forEach(a => a._doc.content = a._doc.content.substring(0, 50) + '...');

          res.render('home/index', {articles: articles});
      });
  }
};
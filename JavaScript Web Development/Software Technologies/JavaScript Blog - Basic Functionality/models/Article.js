const mongoose = require ('mongoose');
const object = mongoose.Schema.Types.ObjectId;

let articleSchema = mongoose.Schema({
    title: {type: String, required: true},
    content: {type: String, required: true},
    author: {type: object, required: true, ref: 'User'},
    date: {type: Date, default: Date.now()}
});

const Article = mongoose.model('Article', articleSchema);
module.exports = Article;
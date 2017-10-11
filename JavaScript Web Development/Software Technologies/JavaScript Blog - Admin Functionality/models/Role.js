const mongoose = require('mongoose');
const Object = mongoose.Schema.Types.ObjectId;

function initializeRole(roleName) {
    let roleData = {name: roleName};

    Role.findOne(roleData).then(role => {
        if (!role) {
            Role.create(roleData);
        }
    });
}

let roleSchema = mongoose.Schema({
    name: {type: String, required: true},
    users: [{type: Object, ref: 'Users'}]
});

const Role = mongoose.model('Role', roleSchema);

module.exports = Role;

module.exports.initialize = () => {
    initializeRole('User');
    initializeRole('Admin');
};
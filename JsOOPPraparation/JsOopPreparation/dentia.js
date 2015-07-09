/**
 * Created by Dentia on 7/7/2015.
 */

function solve(){
    var team,
        validator;

    validator = {
        validateName: function(name){
            if(typeof  name !== 'string'){
                throw {
                    name: 'InvalidNameError',
                    message: 'InvalidNameError'
                }
            }

            var regex = /^[A-Z][a-z]{2,14}$/;
            if(!regex.test(name)){
                throw {
                    name: 'InvalidNameError',
                    message: 'InvalidNameError'
                }
            }
        },
        validateID: function(id, min, max){
            if(id != Number(id)){
                throw {
                    name: 'InvalidIdError',
                    message: 'InvalidIdError'
                }
            }

            id = +id;

            if(id < min || id > max){
                throw {
                    name: 'InvalidIdError',
                    message: 'InvalidIdError'
                }
            }
        }
    };

    //IIFE, so we can have a private scope
    team = (function () {
        var id = 0;

        // an object with all the public functions
        var t = {
            init: function(teamName){
                this.name = teamName;
                this.members = [];

                return this;
            },
            // property getter
            get name(){
                return this._name;
            },
            //property setter
            set name(value){
                validator.validateName(value);
                this._name = value;
            },
            addMember: function(name){
                validator.validateName(name);
                validator.validateID(id);

                this.members.push({
                    name: name,
                    id: ++id
                });

                return this;
            },
            listMembers: function(){
                return this.members.slice();
            },
            removeMember: function(id){

                var found = false;

                for(var ind = 0; ind < this.members.length; ind += 1){
                    if(this.members[ind].id == id) {
                        found = true;
                        break;
                    }
                }

                if(!found){
                    throw 'Hacked!';
                }

                this.members = this.members.filter(function(member){
                    return member.id != id;
                });

                return this;
            }
        };

        return t;
    }());

    return team;
}

///////////////////////////////////////////////////////////////////////////////////////
/////////////////////////Prototypal inheritance////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////

var a = {a:5};
var b = {b:6};


function solve(){
    return {
        a: a,
        b: b
    }
}

var c = Object.create(solve().b);

var c = (function(parent){
    var obj = Object.create(parent);

    Object.defineProperty(obj, 'c', {
            get: function(){return this._c;},
            set: function(value){this._c = value;}
        }
    );

    obj.sayName = function(){
        console.log('I am C!');
    }

    return obj;
}(a));

var something = Object.create(c);
// something.a
// 5
// something.c = 2
// something.c
// 2
// something.sayName()
// I am C!

var a = {
    inint: function(name){
        this.name = name;
    },
    get name(){
        return this._name;
    },
    set name(value){
        this._name = value;
    }
};


var obj = Object.create(a);
obj.inint('NAME')
// obj.name
// "NAME"
var b =(function(parent){
    var o = Object.create(parent);
}(a));


var b =(function(parent){
    var o = Object.create(parent);

    o.init = function(name){
        parent.init.call(this, name);
    }

    return o;

}(a));

var obj2 = Object.create(b);
obj2.inint("NAME2");

// obj2.name
// "NAME2"
// obj.name
// "NAME"
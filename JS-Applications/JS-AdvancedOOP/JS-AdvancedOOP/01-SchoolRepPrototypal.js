var Person = {
    init: function (fName, lName, age) {
        this.firstName = fName;
        this.lastName = lName;
        this.age = age;
    },
    introduce: function () {
        return 'Name:' + this.firstName + ' ' + this.lastName + ',' + 'Age:' + this.age;
    }
};

var Student = Person.extend({

    init: function (fName, lName, age, grade) {
        this._super = Object.create(this._super);
        this._super.init(fName, lName, age);
        this.grade = grade;
    },
    introduce: function () {
        return this._super.introduce() + ',grade:' + this.grade;
    }
});

var Teacher = Person.extend({
    init: function (fName, lName, age, speciality) {
        this._super = Object.create(this._super);
        this._super.init(fName, lName, age);
        this.speciality = speciality;
    },
    introduce: function () {
        return this._super.introduce() + ',speciality:' + this.speciality;
    }
});

var School = {
    init: function (name, town, classes) {
        this.name = name;
        this.town = town;
        this.classes = classes;
    },
    introduce: function () {

        var output = 'Name:' + this.name + ',Town:' + this.town;
        //for (var i = 0; i < this.classes.length; i++) {
        //    if (i == this.classes.length - 1) {

        //        output += this.classes[i];
        //        break;
        //    }
        //    output += this.classes[i] + ',';
        //}
        return output;
    }
};

var Class = {
    init: function (name,capacity,students,teacher) {
        this.name = name;
        this.capacity = capacity;
        this.students = students;
        this.teacher = teacher;
    },
    introduce: function () {
        var output = 'Name:' + this.name + ',Capacity:' + this.capacity;
        //for (var i = 0; i < this.students.length; i++) {
        //    if (i == this.students.length - 1) {
        //        output += this.students[i].introduce();
        //        break;
        //    }
        //    output += this.students[i] + ',';
        //}
        output += ',Teacher:' + this.teacher;
        return output;
    }
}
let { Repository } = require("./solution.js");
let { expect } = require('chai');
const exp = require("constants");

describe('Repository test', () => {
    let properties = {
        name: "string",
        age: "number",
        birthday: "object"
    };

    let entity = {
        name: "Pesho",
        age: 22,
        birthday: new Date(1998, 0, 7)
    };

    describe('Initialization', () => {
        it('Should add props property on init', () => {
            let repository = new Repository(properties);

            expect(repository).to.have.property('props');
            expect(repository.props).to.deep.equal(properties);
            expect(typeof repository.props).to.equal('object');
        });

        it('Should have property data ot init', () => {
            let repository = new Repository(properties);
            expect(repository).to.have.property('data');
            expect(typeof repository.data).is.equal('object');
            expect(repository.data).instanceOf(Map);
        });

        it('Should have next id function on init', () => {
            let repository = new Repository(properties);
            expect(repository).to.have.property('nextId');
            expect(repository.nextId).to.equal('function');
            expect(repository.nextId()).to.equal(0);
        });
    });

    describe('Add entity', () => {
        it('Should return incremented id if valid entity is added', () => {
            let repository = new Repository(properties);

            expect(repository.add(entity)).to.equal(0);
            expect(repository.add(entity)).to.equal(1);
        });

        it('Should store valid entity in data Map', () => {
            let repository = new Repository(properties);
            repository.add(entity)

            expect(repository.data.get(0)).not.to.be.undefined;
            //expect(repository.data.get(0)).to.deep.equal(entity);
            expect(repository.data.get(0)).to.have.property('name').that.equals('Pesho');
            expect(repository.data.get(0)).to.have.property('age').that.equals(22);
            expect(repository.data.get(0)).to.have.property('birthday');
        });

        it('Should throw error if property is missing', () => {
            let entity = {
                name: "Pesho",
                age: 22,
            };

            let repository = new Repository(properties);

            expect(() => repository.add(entity)).to.throw(Error, `Property birthday is missing from the entity!`);
        });

        it('Should throw error if property has other type', () => {
            let entity = {
                name: "Pesho",
                age: 22,
                birthday: '1998-01-06T22:00:00.000Z',
            };

            let repository = new Repository(properties);

            expect(() => repository.add(entity)).to.throw(Error, `Property birthday is not of correct type!`);
        });
    });

    describe('Get count', () => {
        it('Should return number of added valid entities', () => {
            let repository = new Repository(properties);
            repository.add(entity);
            repository.add(entity);
            repository.add(entity);

            expect(repository.count).is.equal(3);
        });

        it('Should return zero of no added entities', () => {
            let repository = new Repository(properties);
            expect(repository.count).is.equal(0);
        });
    });

    describe('Get Id', () => {
        it('Should return entity by id', () => {
            let repository = new Repository(properties);

            let id = repository.add(entity);
            expect(repository.getId(id)).to.deep.equal(entity); // or repository.getId(0)
        });

        it('Should throw error when no id is found', () => {
            let repository = new Repository(properties);
            expect(() => repository.getId(1)).to.throw(Error, `Entity with id: 1 does not exist!`);
        });
    });

    describe('Update', () => {
        it('Should update one valid entity with another', () => {
            let newEntity = {
                name: "Gosho",
                age: 52,
                birthday: new Date(1985, 0, 7)
            };

            let repository = new Repository(properties);

            repository.add(entity);
            repository.update(0, newEntity);

            expect(repository.getId(0).name).to.equal('Gosho');
        });

        it('Should throw error when updating entity on invalid id', () => {

            let repository = new Repository(properties);

            expect(() => repository.update(2, entity)).to.throw(Error, `Entity with id: 2 does not exist!`);
        });
    });

    describe('Delete', () => {
        it('Should delete one valid entity with another', () => {
            let repository = new Repository(properties);

            repository.add(entity);
            repository.add(entity);
            repository.del(0);

            expect(repository.count).to.equal(1);
        });

        it('Should throw error when deleting entity on invalid id', () => {

            let repository = new Repository(properties);

            expect(() => repository.del(2).to.throw(Error, `Entity with id: 2 does not exist!`));
        });
    });
});
// describe('', () => {});
// it('', () => {});
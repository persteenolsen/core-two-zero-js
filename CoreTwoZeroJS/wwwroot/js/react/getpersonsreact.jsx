
class GetPersons extends React.Component {

    constructor(props) {

        super(props)

        this.state = {
            persons: []

        };

    }

    componentDidMount() {

        // Dear team, this is not working when testing locally, and I dont thinkt IE are fully sorting this fetch !!!
        // fetch('https://persons.api.core.persteenolsen.com/api/PersonTableCoreTwoJSApi/')
        //.then(response => response.json())
        //.then(data => { this.setState({ persons: data }) })

        //.catch(error => console.log('error fetching', error))

        // Dear team, use this testing locally and json-data represents the data (at the moment) you should get by fech
         this.setState({ persons: [{ "id": 1, "firstName": "Hans", "lastName": "Hansen", "phone": "11223344", "email": "aaaa@bbb.dk", "age": "48", "editable": "No", "profession": "Sales Man" }, { "id": 2, "firstName": "Per", "lastName": "Olsen", "phone": "33445566", "email": "per@olsen.dk", "age": "51", "editable": "No", "profession": "Web Developer" }, { "id": 4, "firstName": "Ib", "lastName": "Ibsen", "phone": "11887766", "email": "ib@ibsen", "age": "33", "editable": "Yes", "profession": "Fischerman" }, { "id": 8, "firstName": "Ole", "lastName": "Olsen", "phone": null, "email": null, "age": "46", "editable": "Yes", "profession": "Pilot" }, { "id": 10, "firstName": "Lars", "lastName": "Petersen", "phone": null, "email": null, "age": "33", "editable": "Yes", "profession": "Teacher" }] });


    }


    render() {

        return (
            <div>
                <div>Id Name LastName Age Profession</div>
                {this.state.persons.map(person =>
                    <div key={person.id}> {person.id} {person.firstName} {person.lastName} {person.age} {person.profession} </div>)}
            </div>
        );
    }


}


ReactDOM.render(
    <GetPersons />,
    document.getElementById('rootapi')
);

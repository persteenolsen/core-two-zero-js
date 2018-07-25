
class Greeting extends React.Component {
    render() {
        return (<p>Hello world from ReactJS, by loading jsx React components by script tags and loading the react and babel by cdn. 
            I have been using allow-file-access-from-files in Chrome while testing locally.</p>);
    }
     
    
}


ReactDOM.render(
    <Greeting />,
    document.getElementById('rootloadreact')
);

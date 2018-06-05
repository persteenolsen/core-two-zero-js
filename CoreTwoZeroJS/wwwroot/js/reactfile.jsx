
class Greeting extends React.Component {
    render() {
        return (<p>Hello world from ReactJS, by loading a jsx React component...</p>);
    }
     
    
}


ReactDOM.render(
    <Greeting />,
    document.getElementById('root')
);

﻿
class Greeting extends React.Component {
    render() {
        return (<p>Hello world from ReactJS, by loading a jsx React component and using allow-file-access-from-files in Chrome while testing...</p>);
    }
     
    
}


ReactDOM.render(
    <Greeting />,
    document.getElementById('rootloadreact')
);
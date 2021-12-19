import React, { Component } from 'react';

export class ServiceCheck extends Component {
  constructor(props) {
    super(props);
    this.state = {
        storageAccounts :[],
    }
    
  }

  componentDidMount() {
    this.populateAzureData();
  }

  static renderHI(storageAccounts) {
    
    return (
      <table>
        <thead>
          <tr>
            <th>Name</th>
          </tr>
        </thead>
        <tbody>
        {Object.keys(storageAccounts).map(f =>
            <tr key={f.id}>
              <td>{f.name}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {

    console.log("State", this.state.storageAccounts);
    return (
      <div>
        <h1>Service</h1>

        <p>This is a simple example of a React component.</p>


      </div>
    );
  }


  async populateAzureData() {
    const response = await fetch('azuredata');
    console.log("response",response);
    const data = await response.json();
    console.log("data", data);
    this.setState({ storageAccounts: data});
  }
}

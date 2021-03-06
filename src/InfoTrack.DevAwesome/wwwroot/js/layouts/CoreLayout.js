import React, { PropTypes } from 'react';

export default class CoreLayout extends React.Component {
  static propTypes = {
    children : PropTypes.element
  }

  render() {
    return (
      <div className='page-container'>
        <div className='view-container'>
          {this.props.children}
        </div>
      </div>
    );
  }
}

import React from 'react';
import { Button } from '@fluentui/react-components';

function App() {
  return (
    <div style={{ padding: 20 }}>
      <h1>Hello Fluent UI</h1>
      <Button appearance="primary" onClick={() => alert('Button clicked!')}>
        Click Me
      </Button>
    </div>
  );
}

export default App;

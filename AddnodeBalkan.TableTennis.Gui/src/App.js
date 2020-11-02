import React from 'react'
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom'
import MainPage from './pages/MainPage'
import MatchSettingsPage from './pages/MatchSettingsPage'
import PlayerSettingsPage from './pages/PlayerSettings'
import AboutPage from './pages/AboutPage'
import './App.css'

function App() {
  return (
    <div>
      <Router>
        <Switch>
          <React.Fragment>
            <Route path="/" exact component={MainPage} />
            <Route path="/matchsettings" component={MatchSettingsPage} />
            <Route path="/playersettings" component={PlayerSettingsPage} />
            <Route path="/about" component={AboutPage} />
          </React.Fragment>
        </Switch>
      </Router>
    </div>
  )
}

export default App

import React from 'react'
import Grid from '@material-ui/core/Grid'
import NavigationSidebar from '../components/NavigationSidebar'

export default function PlayerSettingsPage() {
  return (
    <div>
      <Grid container justify="center" alignItems="center" spacing={0}>
        <Grid item xs={2}>
          <NavigationSidebar />
        </Grid>
        <Grid item xs={8} style={{ marginTop: '10px' }}>
          Player settings control
        </Grid>
        <Grid item xs={2}></Grid>
      </Grid>
    </div>
  )
}



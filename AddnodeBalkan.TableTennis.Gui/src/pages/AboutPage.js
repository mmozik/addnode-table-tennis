import React from 'react'
import Grid from '@material-ui/core/Grid'
import NavigationSidebar from '../components/NavigationSidebar'
import AddnodeBigLogo from '../images/addnode-logo-big.png'

export default function AboutPage() {
  return (
    <div>
      <Grid
        container
        className="MuiDrawer-paper"
        justify="center"
        alignItems="center"
        spacing={0}
      >
        <Grid item xs={3}>
          <NavigationSidebar />
        </Grid>
        <Grid item xs={9}>
          <img src={AddnodeBigLogo} alt="Table tennis" />
        </Grid>
      </Grid>
    </div>
  )
}

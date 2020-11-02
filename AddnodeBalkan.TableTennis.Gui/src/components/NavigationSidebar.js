import React from 'react'
import Drawer from '@material-ui/core/Drawer'
import AddnodeLogo from './AddnodeLogo'
import MainMenu from './MainMenu'

export default function NavigationSidebar() {
  return (
    <Drawer variant="permanent" anchor="left" style={{ padding: '10px' }}>
      <AddnodeLogo />
      <MainMenu />
    </Drawer>
  )
}

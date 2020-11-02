import React from 'react'
import BuildIcon from '@material-ui/icons/Build'
import FaceIcon from '@material-ui/icons/Face'
import SportsHandballIcon from '@material-ui/icons/SportsHandball'

const MenuOptionContext = React.createContext([
  {
    text: 'START',
    icon: <SportsHandballIcon />,
    url: '/start',
  },
  {
    text: 'MATCH SETTINGS',
    icon: <BuildIcon />,
    url: '/matchsettings',
  },
  {
    text: 'PLAYER SETTINGS',
    icon: <BuildIcon />,
    url: '/playersettings',
  },
  {
    text: 'ABOUT',
    icon: <FaceIcon />,
    url: '/about',
  },
])

export default MenuOptionContext

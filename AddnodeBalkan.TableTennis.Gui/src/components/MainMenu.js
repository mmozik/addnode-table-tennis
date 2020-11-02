import React, { useContext } from 'react'
import List from '@material-ui/core/List'
import MenuOption from './MenuOption'
import MenuOptionContext from '../contexts/MenuOptionContext'

export default function MainMenu() {
  const menuOptions = useContext(MenuOptionContext)

  return (
    <List component="nav">
      {menuOptions &&
        menuOptions.map((option) => (
          <MenuOption key={option.text} {...option} />
        ))}
    </List>
  )
}

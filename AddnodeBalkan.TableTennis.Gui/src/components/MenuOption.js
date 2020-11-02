import React from 'react'
import { Link } from 'react-router-dom'
import ListItem from '@material-ui/core/ListItem'
import ListItemText from '@material-ui/core/ListItemText'

export default function MenuOption({ icon, text, url }) {
  return (
    <ListItem button>
      {icon}
      <Link to={url} style={{ marginLeft: '5px', textDecoration: 'none' }}>
        <ListItemText primary={text} />
      </Link>
    </ListItem>
  )
}

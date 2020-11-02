import React, { useState } from 'react'
import { FormControl, Select, MenuItem, InputLabel } from '@material-ui/core'
import Paper from '@material-ui/core/Paper'
import Typography from '@material-ui/core/Typography'

const styles = {
  fullWidth: { width: '100%' },
  padding: { padding: '20px' }
};

export default function GeneralMatchSettings() {
  const [matchType, setMatchType] = useState()
  const [numberOfSets, setNumberOfSets] = useState()
  const [numberOfPoints, setNumberOfPoints] = useState()

  return (
    <div>
      <Paper variant="outlined" style={styles.padding}>
        <Typography>General settings</Typography>
        <br />
        <FormControl style={styles.fullWidth}>
          <InputLabel id="match-type">Match type</InputLabel>
          <Select
            labelId="match-type"
            id="match-type-select"
            value={matchType}
            onChange={(value) => setMatchType(value)}
          >
            <MenuItem value={1}>Single</MenuItem>
            <MenuItem value={2}>Double</MenuItem>
          </Select>
        </FormControl>
        <br />
        <br />
        <FormControl style={styles.fullWidth}>
          <InputLabel id="demo-customized-select-label">Sets</InputLabel>
          <Select
            labelId="select-sets"
            id="sets"
            value={numberOfSets}
            onChange={(numberOfSets) => setNumberOfSets(numberOfSets)}
          >
            <MenuItem value={1}>1</MenuItem>
            <MenuItem value={3}>3</MenuItem>
          </Select>
        </FormControl>
        <br />
        <br />
        <FormControl style={styles.fullWidth}>
          <InputLabel id="demo-customized-select-label">Points</InputLabel>
          <Select
            labelId="select-points"
            id="points"
            value={numberOfPoints}
            onChange={(numberOfPoints) => setNumberOfPoints(numberOfPoints)}
          >
            <MenuItem value={11}>11</MenuItem>
            <MenuItem value={21}>21</MenuItem>
          </Select>
        </FormControl>
      </Paper>
    </div>
  )
}

# Pluton Rover

A simple implemenation of a pluton rover

## Installation

To run tests

```bash
 dotnet test
```

To run API

```bash
 cd PlutoRover
 PlutoRover build
 dotnet run
```

Swagger 
https://localhost:5001/swagger/index.html

Body

```bash
{
  "movements": [
    "F","F","F","R","R","F","F","R","F","F"
  ],
  "obstacles": [
    {
      "x": 0,
      "y": 0
    }
  ]
}
```
Output
```bash
{
  "x": 2,
  "y": 1,
  "direction": "W",
  "note": null
}
```

Note: Default value for landsacpe X = 10, Y = 10
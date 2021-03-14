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

# Kindly add your responses to the following questions in your README
1. In the assessment did you easily understand what was asked of you?
- A: Yes
2. In the assessment did you feel 2 hours was sufficient in completing the task?
- A: It's enough for the basic concept implementation.
I followed the concept of "baby steps". I would do it more creative if I have more time.

3. Given more time was there any particular area you thought you could improve?

- [ ] Implement available command check
- [ ] Add extra check for the validation input 
- [ ] Improve exception handling
- [ ] Implement different strategies for different movements
- [ ] Implement the ability to use various planets and landscapes
- [] Ability to add more rovers
- [] Ability to pass landscape X and Y as params
- [ ] Obstacles could be moved to a separate logical group
4. Do you have any thoughts or feedback you would like to provide for this
assessment?
It was fun.
 


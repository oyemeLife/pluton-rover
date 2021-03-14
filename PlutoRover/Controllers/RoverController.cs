// <copyright file="RoverController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PlutoRover.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using PlutoRover.RoverCore;
    using PlutoRover.RoverCore.Interface;
    using PlutoRover.RoverCore.Models;

    [ApiController]
    [Route("[controller]")]
    public class RoverController : ControllerBase
    {
        private readonly ILogger<RoverController> logger;
        private readonly IRover rover;
        private readonly ILandscape landscape;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoverController"/> class.
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="rover"></param>
        public RoverController(ILogger<RoverController> logger, IRover rover, ILandscape landscape)
        {
            this.logger = logger;
            this.rover = rover;
            this.landscape = landscape;
        }

        [HttpPost]
        public ActionResult<IPositionState> Get([FromBody] Command command)
        {
            this.landscape.Obstacles = command.Obstacles;

            this.rover.AddMovements(string.Join(string.Empty, command.Movements).ToCharArray());
            this.rover.Move();

            this.logger.LogDebug("Results completed");
            return this.Ok(this.rover.GetCurrentState());
        }
    }
}

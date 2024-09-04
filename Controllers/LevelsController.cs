using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class LevelsController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetLevel(int id)
    {
        var level = new Level // Replace with your actual logic
        {
            LevelId = id,
            Grid = new[]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 0 }
            }
        };

        return Ok(level);
    }
}

public class Level
{
    public int LevelId { get; set; }
    public int[][] Grid { get; set; } // Use jagged array here
}

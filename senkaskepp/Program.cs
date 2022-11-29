using Raylib_cs;
using System.Numerics;
Raylib.InitWindow(900, 900, "Sänka skepp");
Raylib.SetTargetFPS(60);

float speed = 2;

Rectangle boat1 = new Rectangle(100, 600, 50, 20);
Rectangle boat2 = new Rectangle(100, 650, 85, 20);
Rectangle boat3 = new Rectangle(100, 700, 85, 20);
Rectangle boat4 = new Rectangle(100, 750, 125, 20);
Rectangle boat5 = new Rectangle(100, 800, 150, 20);
Rectangle currBoat = new Rectangle(0, 0, 0, 0);

float tileSize = 32;
int gridSize = 10;
Vector2 firstGridOffset = new Vector2(500, 100);
Vector2 secondGridOffset = new Vector2(500, 500);
 
string currentScene = "preGame";

while (Raylib.WindowShouldClose() == false)
{



    //logik

    if (currentScene == "game")
    {

    }

    else if (currentScene == "preGame")
    {
        // if (Raylib.IsKeyDown(KeyboardKey.KEY_ONE)){
        //     boat1 = currBoat;
        // }
        // if (Raylib.IsKeyDown(KeyboardKey.KEY_TWO)){
        //     boat2 = currBoat;
        // }
        // if (Raylib.IsKeyDown(KeyboardKey.KEY_THREE)){
        //     boat3 = currBoat;
        // }
        // if (Raylib.IsKeyDown(KeyboardKey.KEY_FOUR)){
        //     boat4 = currBoat;
        // }
        // if (Raylib.IsKeyDown(KeyboardKey.KEY_FIVE)){
        //     boat5 = currBoat;
        // }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            boat4.y -= speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            boat4.x -= speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            boat4.y += speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            boat4.x += speed;
        }
    }


    else if (currentScene == "start")
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
        {
            currentScene = "preGame";
        }

    }

    //grafik

    Raylib.ClearBackground(Color.BLUE);
    Raylib.BeginDrawing();

    if (currentScene == "game")
    {


    }

    else if (currentScene == "preGame")
    {
        // Raylib.DrawTexture(board, 400, 500, Color.WHITE);
        // Raylib.DrawTexture(enemyBoard, 400, 50, Color.WHITE);
        // Raylib.DrawRectangleRec(boat1, Color.GRAY);
        // Raylib.DrawRectangleRec(boat2, Color.GRAY);
        // Raylib.DrawRectangleRec(boat3, Color.GRAY);
        // Raylib.DrawRectangleRec(boat4, Color.GRAY);
        // Raylib.DrawRectangleRec(boat5, Color.GRAY);

        DrawGrid(tileSize, gridSize, firstGridOffset);
        DrawGrid(tileSize, gridSize, secondGridOffset);

    }
    else if (currentScene == "start")
    {
        Raylib.DrawText("Press  ENTER to start", 215, 300, 32, Color.BLACK);
        Raylib.DrawText("Press  ESC to quit", 20, 860, 20, Color.BLACK);

    }


    Raylib.EndDrawing();
}



static void DrawGrid(float tileSize, int gridSize, Vector2 offset)
{
    for (var x = 0; x < gridSize + 1; x++)
    {
        Vector2 startV = offset + new Vector2(x * tileSize, 0);
        Vector2 endV = offset + new Vector2(x * tileSize, tileSize * (gridSize));
        Raylib.DrawLineEx(startV, endV, 3, Color.YELLOW);
    }
    for (var y = 0; y < gridSize + 1; y++)
    {
        Vector2 startH = offset + new Vector2(0, y * tileSize);
        Vector2 endH = offset + new Vector2(tileSize * (gridSize), y * tileSize);
        Raylib.DrawLineEx(startH, endH, 3, Color.YELLOW);
    }
    for (var num = 0; num < gridSize; num++)
    
    {
        Raylib.DrawText("1", offset + tileSize, 0, 14, Color.YELLOW);
    }

}

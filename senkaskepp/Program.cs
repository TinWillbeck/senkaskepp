using Raylib_cs;
using System.Numerics;
Raylib.InitWindow(900, 900, "Sänka skepp");
Raylib.SetTargetFPS(60);

float speed = 2;

int boat1 = 2;
int boat2 = 3;
int boat3 = 3;
int boat4 = 4;
int boat5 = 5;

float tileSize = 32;
int gridSize = 10;
Vector2 firstGridOffset = new Vector2(500, 100);
Vector2 secondGridOffset = new Vector2(500, 500);
 
string currentScene = "start";

while (Raylib.WindowShouldClose() == false)
{

    //logik

    if (currentScene == "game")
    {
        // kolla vems tur det är, 
        // be spelaren om en plats på kartan där en bomb ska skickas, 
        // skicka bomb, 
        // checka om det är en båt i rutan, 
        // markera rutan
        // byt tur
    }

    else if (currentScene == "preGame")
    {
        
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
        DrawGrid(tileSize, gridSize, firstGridOffset);
        DrawGrid(tileSize, gridSize, secondGridOffset);

    }

    else if (currentScene == "preGame")
    {



        DrawGrid(tileSize, gridSize, firstGridOffset);
        DrawGrid(tileSize, gridSize, secondGridOffset);
        PlaceBoat(100, boat1, tileSize, gridSize, secondGridOffset);

    }
    else if (currentScene == "start")
    {
        Raylib.DrawText("Press  ENTER to start", 215, 300, 32, Color.BLACK);
        Raylib.DrawText("Press  ESC to quit", 20, 860, 20, Color.BLACK);

    }


    Raylib.EndDrawing();
}

static void PlaceBoat(int placement, int boat, float tileSize, int gridSize, Vector2 offset)
{
    
    for (var i = 0; i < boat; i++)
    {
        
    }
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
        
    }

}

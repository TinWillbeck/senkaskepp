using Raylib_cs; 
using System.Numerics;
Raylib.InitWindow(900, 900, "Sänka skepp");
Raylib.SetTargetFPS(60);

Texture2D board = Raylib.LoadTexture("board.png");
Texture2D enemyBoard = Raylib.LoadTexture("board.png");

string currentScene = "start";

while (Raylib.WindowShouldClose() == false){



    //logik

    if (currentScene == "game"){

    }
    else if (currentScene == "start"){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER)){
            currentScene = "game";
        }

    }

    //grafik

    Raylib.ClearBackground(Color.BLUE);
    Raylib.BeginDrawing();
    if (currentScene == "game"){
        Raylib.DrawTexture(board, 400, 500, Color.WHITE);
        Raylib.DrawTexture(enemyBoard, 400, 50, Color.WHITE);
    }

    else if (currentScene == "start"){
        Raylib.DrawText("Press  ENTER to start", 215, 300, 32, Color.BLACK);
        Raylib.DrawText("Press  ESC to quit", 20, 860, 20, Color.BLACK);

    }


    Raylib.EndDrawing();
}


Console.ReadLine();

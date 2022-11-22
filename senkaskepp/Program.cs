using Raylib_cs; 
using System.Numerics;
Raylib.InitWindow(900, 900, "Sänka skepp");
Raylib.SetTargetFPS(60);

float speed = 30;
Texture2D board = Raylib.LoadTexture("board.png");
Texture2D enemyBoard = Raylib.LoadTexture("board.png");

Rectangle boat1 = new Rectangle(100, 600, 50, 20);
Rectangle boat2 = new Rectangle(100, 650, 70, 20);
Rectangle boat3 = new Rectangle(100, 700, 70, 20);
Rectangle boat4 = new Rectangle(100, 750, 100, 20);
Rectangle boat5 = new Rectangle(100, 800, 150, 20);

string currentScene = "start";

while (Raylib.WindowShouldClose() == false){



    //logik

    if (currentScene == "game"){

    }
    
    else if (currentScene == "preGame"){
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE)){
            if (Raylib.IsKeyDown(KeyboardKey.KEY_W)){
                boat1.y += speed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A)){
                boat1.y -= speed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S)){
                boat1.x -= speed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D)){
                boat1.y += speed;
            }
        }
    }
    
    else if (currentScene == "start"){
        if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER)){
            currentScene = "preGame";
        }

    }

    //grafik

    Raylib.ClearBackground(Color.BLUE);
    Raylib.BeginDrawing();

    if (currentScene == "game"){
        Raylib.DrawTexture(board, 400, 500, Color.WHITE);
        Raylib.DrawTexture(enemyBoard, 400, 50, Color.WHITE);
    }

    else if (currentScene == "preGame"){
        Raylib.DrawTexture(board, 400, 500, Color.WHITE);
        Raylib.DrawTexture(enemyBoard, 400, 50, Color.WHITE);
        Raylib.DrawRectangleRec(boat1, Color.GRAY);
        Raylib.DrawRectangleRec(boat2, Color.GRAY);
        Raylib.DrawRectangleRec(boat3, Color.GRAY);
        Raylib.DrawRectangleRec(boat4, Color.GRAY);
        Raylib.DrawRectangleRec(boat5, Color.GRAY);
        
    }
    else if (currentScene == "start"){
        Raylib.DrawText("Press  ENTER to start", 215, 300, 32, Color.BLACK);
        Raylib.DrawText("Press  ESC to quit", 20, 860, 20, Color.BLACK);

    }


    Raylib.EndDrawing();
}


Console.ReadLine();

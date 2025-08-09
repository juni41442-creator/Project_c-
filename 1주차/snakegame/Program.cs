

using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    // 게임판 크기
    const int Width = 30;
    const int Height = 40;

    // 게임 상태
    static bool isGameOver = false;

    // 뱀의 몸통 좌표 리스트
    static List<(int x, int y)> snake = new List<(int x, int y)>();
    // 먹이 좌표
    static (int x, int y) food;

    // 뱀의 이동 방향
    static string direction = "right";

    static void Main(string[] args)
    {
        Console.WindowWidth = Width + 2;
        Console.WindowHeight = Height + 2;
        Console.CursorVisible = false;

        InitializeGame();

        while (!isGameOver)
        {
            HandleInput();
            MoveSnake();
            CheckCollisionAndFood();
            DrawGame();

            Thread.Sleep(200);
        }

        Console.Clear();
        Console.SetCursorPosition(Width / 2 - 5, Height / 2);
        Console.WriteLine("게임 오버!");
        Console.ReadKey();
    }

    static void InitializeGame()
    {
        snake.Add((Width / 2, Height / 2)); // 뱀 시작 위치
        PlaceFood();
    }

    static void PlaceFood()
    {
        Random rand = new Random();
        food = (rand.Next(1, Width - 1), rand.Next(1, Height - 1));

        // 먹이가 뱀 몸통 위에 생성되지 않도록 확인
        while (snake.Contains(food))
        {
            food = (rand.Next(1, Width - 1), rand.Next(1, Height - 1));
        }
    }

    static void HandleInput()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (direction != "down") direction = "up";
                    break;
                case ConsoleKey.DownArrow:
                    if (direction != "up") direction = "down";
                    break;
                case ConsoleKey.LeftArrow:
                    if (direction != "right") direction = "left";
                    break;
                case ConsoleKey.RightArrow:
                    if (direction != "left") direction = "right";
                    break;
            }
        }
    }

    static void MoveSnake()
    {
        // 현재 머리 위치 가져오기
        var head = snake[0];
        (int x, int y) newHead = head;

        // 방향에 따라 새로운 머리 위치 계산
        switch (direction)
        {
            case "up":
                newHead = (head.x, head.y - 1);
                break;
            case "down":
                newHead = (head.x, head.y + 1);
                break;
            case "left":
                newHead = (head.x - 1, head.y);
                break;
            case "right":
                newHead = (head.x + 1, head.y);
                break;
        }

        // 새로운 머리를 리스트 맨 앞에 추가
        snake.Insert(0, newHead);

        // 먹이를 먹지 않았으면 꼬리 제거
        if (newHead.x != food.x || newHead.y != food.y)
        {
            snake.RemoveAt(snake.Count - 1);
        }
        else
        {
            PlaceFood(); // 먹이를 먹었으면 새로운 먹이 배치
        }
    }

    static void CheckCollisionAndFood()
    {
        var head = snake[0];

        // 벽에 부딪혔는지 확인
        if (head.x < 0 || head.x >= Width || head.y < 0 || head.y >= Height)
        {
            isGameOver = true;
        }

        // 자신의 몸통에 부딪혔는지 확인
        for (int i = 1; i < snake.Count; i++)
        {
            if (head.x == snake[i].x && head.y == snake[i].y)
            {
                isGameOver = true;
                break;
            }
        }
    }

    static void DrawGame()
    {
        Console.Clear();

        // 게임판 경계 그리기
        for (int i = 0; i < Width + 2; i++)
        {
            Console.SetCursorPosition(i, 0); Console.Write("#");
            Console.SetCursorPosition(i, Height + 1); Console.Write("#");
        }
        for (int i = 0; i < Height + 2; i++)
        {
            Console.SetCursorPosition(0, i); Console.Write("#");
            Console.SetCursorPosition(Width + 1, i); Console.Write("#");
        }

        // 뱀 그리기
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var segment in snake)
        {
            Console.SetCursorPosition(segment.x + 1, segment.y + 1);
            Console.Write("■");
        }

        // 먹이 그리기
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(food.x + 1, food.y + 1);
        Console.Write("●");

        Console.ResetColor();
    }
}
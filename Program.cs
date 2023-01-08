double health1 = 0, attack1 = 0, speed1 = 0;
double  health2 = 0, attack2 = 0, speed2 = 0;
int round = 0;
double number = Random.Shared.Next(-15, 15);
double random = 0;
random = number/ 100d;

#region CONSTANTS
const double PIRATE_HEALTH = 20;
const double PIRATE_ATTACK = 3;
const double PIRATE_ARMOR = 3;
const double PIRATE_SPEED = 3;

const double STONE_CHEWER_HEALTH = 50;
const double STONE_CHEWER_ATTACK = 8;
const double STONE_CHEWER_ARMOR = 10;
const double STONE_CHEWER_SPEED = 1;

const double GHOST_WARRIOR_HEALTH = 20;
const double GHOST_WARRIOR_ATTACK = 2;
const double GHOST_WARRIOR_ARMOR = 2;
const double GHOST_WARRIOR_SPEED = 5;

const double OUTWORLDER_HEALTH = 15;
const double OUTWORLDER_ATTACK = 1;
const double  OUTWORLDER_ARMOR = 2;
const double  OUTWORLDER_SPEED = 10;

const double MONSTER_KNIGHT_HEALTH = 15;
const double  MONSTER_KNIGHT_ATTACK = 4;
const double MONSTER_KNIGHT_ARMOR = 3;
const double  MONSTER_KNIGHT_SPEED = 3;

const double  DARK_GOBLIN_HEALTH = 10;
const double DARK_GOBLIN_ATTACK = 1;
const double DARK_GOBLIN_ARMOR = 8;
const double DARK_GOBLIN_SPEED = 3;

const string PIRATE = "pirate";
const string STONE_CHEWER = "stone chewer";
const string GHOST_WARRIOR = "ghost warrior";
const string OUTWORLDER = "outworlder";
const string MONSTER_KNIGHT = "monster knight";
const string DARK_GOBLIN = "dark goblin";
#endregion 

Console.WriteLine("Player 1 , choose your character: ");
Console.WriteLine($"> {PIRATE} ");
Console.WriteLine($"> {STONE_CHEWER}");
Console.WriteLine($"> {GHOST_WARRIOR} ");
Console.WriteLine($"> {OUTWORLDER}");
Console.WriteLine($"> {MONSTER_KNIGHT}");
Console.WriteLine($"> {DARK_GOBLIN}");

string player1 = Console.ReadLine()!;

Console.Write("Player 2, choose your character: ");
string player2 = Console.ReadLine()!;

switch (player1)
{
    case PIRATE:
        health1 = PIRATE_HEALTH + PIRATE_ARMOR;
        attack1 = PIRATE_ATTACK;
        speed1 = PIRATE_SPEED; break;

    case STONE_CHEWER:
        health1 = STONE_CHEWER_HEALTH + STONE_CHEWER_ARMOR;
        attack1 = STONE_CHEWER_ATTACK;
        speed1 = STONE_CHEWER_SPEED; break;

    case GHOST_WARRIOR:
        health1 = GHOST_WARRIOR_HEALTH + GHOST_WARRIOR_ARMOR;
        attack1 = GHOST_WARRIOR_ATTACK;
        speed1 = GHOST_WARRIOR_SPEED; break;

    case OUTWORLDER:
        health1 = OUTWORLDER_HEALTH + OUTWORLDER_ARMOR;
        attack1 = OUTWORLDER_ATTACK;
        speed1 = OUTWORLDER_SPEED;
        break;

    case MONSTER_KNIGHT:
        health1 = MONSTER_KNIGHT_HEALTH + MONSTER_KNIGHT_ARMOR;
        attack1 = MONSTER_KNIGHT_ATTACK;
        speed1 = MONSTER_KNIGHT_SPEED;
        break;

    case DARK_GOBLIN:
        health1 = DARK_GOBLIN_HEALTH + DARK_GOBLIN_ARMOR;
        attack1 = DARK_GOBLIN_ATTACK;
        speed1 = DARK_GOBLIN_SPEED;
        break;

    default: Console.WriteLine("Try again!"); break;
}

switch (player2)
{
    case PIRATE:
        health2 = PIRATE_HEALTH + PIRATE_ARMOR;
        attack2 = PIRATE_ATTACK;
        speed2 = PIRATE_SPEED; 
        break;

    case STONE_CHEWER:
        health2 = STONE_CHEWER_HEALTH + STONE_CHEWER_ARMOR;
        attack2 = STONE_CHEWER_ATTACK;
        speed2 = STONE_CHEWER_SPEED;
         break;

    case GHOST_WARRIOR:
        health2 = GHOST_WARRIOR_HEALTH + GHOST_WARRIOR_ARMOR;
        attack2 = GHOST_WARRIOR_ATTACK;
        speed2 = STONE_CHEWER_SPEED; 
        break;

        case OUTWORLDER:
        health2 = OUTWORLDER_HEALTH + OUTWORLDER_ARMOR;
        attack2 = OUTWORLDER_ATTACK;
        speed2 = OUTWORLDER_SPEED;
        break;

    case MONSTER_KNIGHT:
        health2 = MONSTER_KNIGHT_HEALTH + MONSTER_KNIGHT_ARMOR;
        attack2 = MONSTER_KNIGHT_ATTACK;
        speed2 = MONSTER_KNIGHT_SPEED;
        break;

    case DARK_GOBLIN:
        health2 = DARK_GOBLIN_HEALTH + DARK_GOBLIN_ARMOR;
        attack2 = DARK_GOBLIN_ATTACK; 
        speed2 = DARK_GOBLIN_SPEED;
        break;

    default: Console.WriteLine("Try again "); break;
}

while (health1 > 0 && health2 > 0)
{
    round++;
    random = number/ 100d;
    health1 -= ((attack2 * random)* speed2);
    health2 -= ((attack1 * random) * speed1);
}
if (health1 > 0)
{
    Console.Write($"Player 1 , congrationlations, you won after {round} rounds ");
}
else if (health2 > 0)
{
    Console.Write($"Player 2, congrationlations you won {round} ");
}
else Console.Write("It is a DRAW");   
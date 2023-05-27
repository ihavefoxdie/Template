using Template;
using Template.Classes;


FriendlyChar npc = new("Thomas");
EnemyChar rival = new("Hooligan");
InformantChar tutorialNPC = new("Kristine");
Bird bird = new();

Client.ExecuteRoutine(npc);
Client.ExecuteRoutine(rival);
Client.ExecuteRoutine(tutorialNPC);
Client.ExecuteRoutine(bird);


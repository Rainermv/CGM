//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.544
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
namespace CGME
{
	public class GameBuilder
	{

		private static CGME.Game game = null;

		public GameBuilder ()
		{

		}
		public static CGME.Player AddPlayer(string name, bool enable =true){// BUILDING PLAYERS
			//CGME.Player game_player = Factory.BuildPlayer(name, enable);
			return game.AddPlayer (new CGME.Player("name"));
		}
		public static CGME.Game Build(){
			// BUILDING THE GAME TABLE
			game = new CGME.Game();

			// BUILDING PLAYERS
			//CGME.Player game_player = Factory.BuildPlayer("Game Player", true);
			game.AddPlayer (new Player("Game Player"));

			//CGME.Player human_player = Factory.BuildPlayer("Human Player", true);
			game.AddPlayer (new Player("Human Player"));
		
				// ADDING RESOURCES
				game.AddResource(new Resource<int>("Life Points",30), "Human Player");
				game.AddResource(new Resource<int>("Life Points",30), "Game Player");
				
				game.AddResource (new Resource<int>("Victory Points", 0), "Human Player");

				// BUILDING DECKS
				game.GetPlayer("Human Player").AddDeck(new Deck("Draw Pile"));
				
					// BUILDING CARDS
					for (int i = 1; i <= 2; i++){
						game.GetPlayer ("Human Player").GetDeck ("Draw Pile").AddCard(new Card("Dwarf Dork"));						
						game.AddResource(new Resource<string>("Description", "Drunk and Smelly"),"Dwarf Dork");
					}

			// BUILDING RULESET
			game.AddRuleset(new Ruleset("Standard"));
			
				// BUILDING PHASES
				game.GetRuleset ("Standard").AddPhase (new Phase("Draw Phase"));
				game.GetRuleset ("Standard").AddPhase (new Phase("Play Phase"));

					// BUILDING ACTIONS
					game.GetRuleset ("Standard").GetPhase ("Draw Phase").AddAction(new EndPhaseAction("End Phase"));
					game.GetRuleset ("Standard").GetPhase("Draw Phase").AddAction(new SubtractResourceAction("Damage","Life Points", 5));
					
					game.GetRuleset ("Standard").GetPhase ("Play Phase").AddAction(new EndGameAction("End Game"));
				
			return game;
		}
	}
}

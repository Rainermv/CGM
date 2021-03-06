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
using System.Collections.Generic;

namespace CGME
{
	public class Player : CGME.Actor
	{
		private List<CGME.Deck> decks = new List<CGME.Deck>();

		// CONSTRUCTORS ------------------------------------------
		public Player(){

		}

		public Player(string name, bool enabled = true){
			Name = name;
			Enabled = enabled;
		}

		// GET/SET FUNCTIONS -----------------------------
		
		public Deck GetDeck(CGME.Deck _deck){
			
			foreach (var deck in decks) {
				if (deck == _deck)
					return deck;
			}
			
			return null;
		}
		
		public Deck GetDeck(string name){
			foreach (var deck in decks) {
				if (deck.Name == name)
					return deck;
			}
			
			return null;
		}

		public Deck GetDeck(int index){
			return decks[index];
		}

		public int Decks_Size{
			get { return decks.Count;}
		}
		
		
		// LIST FUNCTIONS ----------------------------------------
		
		public Deck AddDeck(CGME.Deck new_deck){
			decks.Add(new_deck);
			return new_deck;
		}
		
		public Deck AddDeck(string name){
			Deck deck = new Deck(name);
			decks.Add(deck);
			return deck;
		}
		
		public void RemoveDeck(CGME.Deck deck){
			decks.Remove(deck);
		}

		public void RemoveDeck(int index){
			decks.RemoveAt(index);
		}
		
		public void ClearDecks(){
			decks.Clear();
		}
		
		// PUBLIC FUNCTIONS --------------------------------------
		
		public Actor FindActor(string actor_name){
			
			if (this.Name == actor_name) return this;
			
			foreach (Deck actor in decks){
				if (actor.FindActor(actor_name)!= null) return (Actor)actor;
			}
			
			return null;
		}


	}
}



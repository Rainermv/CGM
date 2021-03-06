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
	public class Deck : CGME.Actor
	{
		// PRIVATE ------------------------------------------------
		private List<CGME.Card> cards = new List<CGME.Card>();

		// CONSTRUCTORS --------------------------------------------

		public Deck(string name, bool enabled = true){
			Name = name;
			this.enabled = enabled;
		}

		// GET/SET FUNCIONS -----------------------------------------

		public CGME.Card GetCard(CGME.Card _card)
		{
			foreach (var card in cards) {
				if (card == _card)
					return card;
			}
			return null;
		}

		public CGME.Card GetCard(string name)
		{
			foreach (var card in cards) {
				if (card.Name == name)
					return card;
			}
			return null;
		}

		public Card GetCard(int index){
			return cards[index];
		}

		public int Cards_Size{
			get { return cards.Count;}
		}

		// LIST FUNCTIONS ------------------------------------------

		public void AddCard(CGME.Card card){
			cards.Add(card);
		}
		
		public void RemoveCard(int index){
			cards.RemoveAt(index);
		}
		
		public void RemoveCard(CGME.Card card){
			cards.Remove(card);
		}

		public void ClearCards(){
			cards.Clear();
		}

		// PUBLIC FUNCTIONS ------------------------------------------

		public void Enable(bool enable){
		
			this.enabled = enable;
			
			EnableResources(enable);
			
			foreach (Card card in cards){
				card.Enable(enable);
			}
		}

		public void Shuffle()
		{
		}

		public void Sort()
		{
		}
		
		public Actor FindActor(string actor_name){
		
			//GameManager.DebugLog(this.Name + " :: " + actor_name);
			
			if (this.Name == actor_name) return this;
			
			foreach (Card actor in cards){
				Actor found = actor.FindActor(actor_name);
				if (found != null) {
					//GameManager.DebugLog("Returning " + found.Name);
					return found;
				}
			}
			
			return null;
		}
	}
}


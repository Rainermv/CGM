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
using System.Collections;
//using JokerEngine;

namespace CGME
{
	public class Card : CGME.Actor

	{
		public Card(string name, bool enabled = true){
			Name = name;
			Enable (enabled);
		}
		
		public void Enable(bool enable){
		
			EnableResources(enable);
				
			enabled = enable;
		}
		
		
		public Actor FindActor(string actor_name){
		
			//GameManager.DebugLog(this.Name + " :: " + actor_name);
			
			if (this.Name == actor_name){
				//GameManager.DebugLog("Returning " + actor_name);
				return this;
			}
			
			return null;
		}
				                           
	}

}

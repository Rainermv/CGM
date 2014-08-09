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
	public class Ruleset : CGME.Actor
	{
		// PRIVATE ----------------------------------------------

		private List<CGME.Phase> phases = new List<CGME.Phase>();

		public int phase_iterator = 0;

		// CONSTRUCTOR ------------------------------------------
		public Ruleset(string name, bool enabled = true){
			Name = name;
			Enabled = enabled;
		}

		// GET/SET FUNCTIONS -----------------------------
		
		public Phase GetPhase(CGME.Phase _phase){
			
			foreach (var phase in phases) {
				if (phase == _phase)
					return phase;
			}
			
			return null;
		}

		public Phase GetPhase(string name){
			foreach (var phase in phases) {
				if (phase.Name == name)
					return phase;
			}
			
			return null;
		}

		public Phase GetPhase(int index){
			return phases[index];
		}

		public int Phases_Size{
			get { return phases.Count;}
		}
		
		// LIST FUNCTIONS ----------------------------------------
		
		public void AddPhase(CGME.Phase new_phase){
			phases.Add(new_phase);
		}
		
		public void RemovePhase(CGME.Phase phase){
			phases.Remove(phase);
		}

		public void RemovePhase(int index){
			phases.RemoveAt(index);
		}
		
		public void ClearPhases(){
			phases.Clear();
		}

		// PRIVATE FUNCTIONS --------------------------------------

		private void Iterate(){

			phase_iterator++;  // go to next phase
			if (phase_iterator >= Phases_Size)
				phase_iterator = 0;  // go to phase zero

		}
		// PUBLIC FUNCTIONS ---------------------------------------

		// return the next phase or to phase zero
		public CGME.Phase NextPhase(){

			CGME.Phase phase = GetPhase(phase_iterator);
			Iterate();
			return phase;

		}
		
		public Actor FindActor(string actor_name){
			
			if (this.Name == actor_name) return this;
			
			foreach (Phase actor in phases){
				if (actor.FindActor(actor_name)!= null) return (Actor)actor;
			}
			
			return null;
		}



	}
}

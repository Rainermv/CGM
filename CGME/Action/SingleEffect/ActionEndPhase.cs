//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.18408
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
namespace CGME
{
	public class ActionEndPhase : ActionSingleEffect
	{
		
		public ActionEndPhase (string name, bool enabled = true)
		{
			this.Name = name;
			this.enabled = enabled;
		}

		public override bool Effect(){
		
			GameManager.DebugLog("Issuing Action: Next Phase");
			
			GameManager.GetInstance().CommandEndPhase();

			return true;
		}
		
	}
}


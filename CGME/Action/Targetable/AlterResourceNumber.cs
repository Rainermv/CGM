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
	public class AlterResourceNumber : ActionTargetable
	{
		public AlterResourceNumber (Actor target, int Modifier)
		{
			AddResource(new ResourceNumber("Alter Value",Modifier));
			this.Target = target;
		}
		
		public override bool Effect ()
		{
			
			Target.GetResource(Resources[0].Name).AddResource()
			
		}
		
		
	}
}


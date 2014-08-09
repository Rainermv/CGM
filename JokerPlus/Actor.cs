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
	[Serializable]
	public class Actor
	{
		// PRIVATE ----------------------------------------------
		private List<CGME.Resource> resources = new List<CGME.Resource>();

		private string name;
		private bool enabled;

		// CONSTRUCTOR ------------------------------------------

		public Actor(){

		}

		public Actor (string name, bool enabled = true){
			Name = name;
			Enabled = enabled;
		}

		// GET/SET FUNCTIONS ----------------------------------------

		public List<Resource> Resources{
			get{return resources;}
		}

		public string Name{
			get{ return name;}
			set{ name = value;}
		}

		public bool Enabled{
			get{ return enabled;}
			set{enabled = value;}
			}

		public Resource GetResource(string name){
			
			foreach (var resource in resources) {
				//CGME.GameManager.DebugLog("DEBUG - GET RESOURCE, NAME == "+ resource.Name);
				if (resource.Name == name)
					return resource;
			}

			return null;
		}

		public Resource GetResource(int index){
			return resources[index];
		}

		public int Resources_Size{
			get{return resources.Count;}
		}

		// RESOURCES FUNCTIONS ----------------------------------------

		public void AddResource(CGME.Resource new_resource){
			resources.Add(new_resource);
		}

		public void RemoveResource(int index){
			resources.RemoveAt(index);
		}

		public void RemoveResource(CGME.Resource resource){
			resources.Remove(resource);
		}

		public void ClearResources(){
			resources.Clear();
		}

	
	}
}

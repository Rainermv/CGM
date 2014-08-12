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
	public abstract class Resource : CGME.Actor
	{
		//TODO Implement generic value
		//private T value;
	
		public Resource(){

		}
		public Resource(string name){
			Name = name;
			enabled = false;
		}

		//public T getValue(){
		//	return value;
		//}
		public abstract void Enable(bool enable);
	

	}

	public class ResourceNumber : CGME.Resource
	{
		private int _value;

		public ResourceNumber(string name, int value, bool enabled = true){

			this.Name = name;
			this.Value = value;
			this.enabled = enabled;

		}

		public int Value{
			get{return _value;}
			set{_value = value;}
		}
		
		public override void Enable (bool enable)
		{
			this.enabled = enable;
		}
		
		public override string ToString(){
			return (name + ": " + Value.ToString());
		}
		
		public bool AddValue(int value){
			Value+= Value;
		}
		
		public bool SetValue(int value){
			Value = Value;
		}
		
	}
	
	public class ResourceText : CGME.Resource
	{
		private string _value;
		
		public ResourceText(string name, string value, bool enabled = true){
			
			this.Name = name;
			this.Value = value;
			this.enabled = enabled;
			
		}
		
		public string Value{
			get{return _value;}
			set{_value = value;}
		}
		
		public override void Enable (bool enable)
		{
			this.enabled = enable;
		}
		
		public override string ToString(){
			return (name + ": " + Value);
		}
		
		public bool AddValue(string value){
			Value+= " " + Value;
		}
		
		public bool SetValue(string value){
			Value = Value;
		}
		
	}
	
	public class ResourceAction : CGME.Resource{
	
		private string phase;
		private Action action;
		
		public ResourceAction(string phase, Action action, bool enabled = true){
			this.phase = phase;
			this.action = action;
			this.enabled = enabled;
			
			this.name = "Action:";
			//AddAction ();
		}
		
		public void AddAction(){
			GameManager.GetInstance ().AddAction(action, phase);
		}
		
		public void RemoveAction(){
			GameManager.GetInstance ().RemoveAction(action, phase);
		}
		
		public override void Enable (bool enable)
		{
			this.enabled = enable;
			
			if (enable) AddAction();
			else 		RemoveAction();
		}
		
		
		public override string ToString(){
			return (action.Name + " : " + phase);
		}
	}
}

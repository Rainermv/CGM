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
using UnityEditor;
using UnityEngine;

namespace CGM
{


	public class Window : EditorWindow
	{
		private string window_name = "default";
		private bool enabled = false;

		[MenuItem ("Window/CGE/Add player") ]
			public static void ShowWindow(){

			EditorWindow.GetWindow(typeof(CGM.Window));
		}

		void OnGUI(){

			GUILayout.Label("Hello World");

			name = EditorGUILayout.TextField("Player Name", window_name);
			enabled = EditorGUILayout.Toggle("Enabled", enabled);

			if (GUILayout.Button("+"))
				CGME.GameBuilder.AddPlayer(name, enabled);
				

		}


	}
}


﻿/************************************************************************/
/* Copyright (C) 2011-2015 Impulsonic Inc. All Rights Reserved.         */
/*                                                                      */
/* The source code, information  and  material ("Material") contained   */
/* herein is owned  by Impulsonic Inc. or its suppliers or licensors,   */
/* and title to such  Material remains  with Impulsonic  Inc.  or its   */
/* suppliers or licensors. The Material contains proprietary informa-   */
/* tion  of  Impulsonic or  its  suppliers and licensors. No  part of   */
/* the Material may be used, copied, reproduced, modified, published,   */
/* uploaded, posted, transmitted, distributed or disclosed in any way   */
/* without Impulsonic's prior express written permission. No  license   */
/* under  any patent, copyright or other intellectual property rights   */
/* in the Material is  granted  to  or  conferred  upon  you,  either   */
/* expressly, by implication, inducement, estoppel or otherwise.  Any   */
/* license  under  such intellectual property rights must  be express   */
/* and approved by Impulsonic in writing.                               */
/*                                                                      */
/* Third Party trademarks are the property of their respective owners.  */
/*                                                                      */
/* Unless otherwise  agreed upon by Impulsonic  in  writing, you  may   */
/* not remove or  alter this  notice or any other  notice embedded in   */
/* Materials by Impulsonic or Impulsonic's  suppliers or licensors in   */
/* any way.                                                             */
/************************************************************************/

using UnityEngine;
using UnityEditor;
using UnityEditorInternal;


namespace Phonon
{
	//
	// Phonon3DListenerInspector
	// Custom inspector for Phonon3DListener.
	//
	[CustomEditor(typeof(Phonon3DListener))]
	public class Phonon3DListenerInspector : Editor
	{
		//
		// Displays the Inspector GUI.
		//
		public override void OnInspectorGUI()
		{
			serializedObject.Update();

			PhononGUI.SectionHeader("Performance Settings");
			EditorGUILayout.PropertyField(serializedObject.FindProperty("MaxSources"));
			EditorGUILayout.PropertyField(serializedObject.FindProperty("MaxDistance"));
			EditorGUILayout.Space();

			serializedObject.ApplyModifiedProperties();
		}
	}
}
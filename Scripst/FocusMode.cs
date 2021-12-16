using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class FocusMode : MonoBehaviour {

	//Hace foco automaticamente, generalmente el mas usado
	public void modoContinuousAuto () {
		CameraDevice.Instance.SetFocusMode (CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
	}



}

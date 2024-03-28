using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform target; // The target the camera will follow
	public float smoothSpeed = 0.125f; // The speed at which the camera follows the target
	public Vector3 offset; // The offset from the target's position

	void FixedUpdate()
	{
		if (target == null)
		{
			Debug.LogWarning("Camera target is not assigned.");
			return;
		}

		// Calculate the desired position and rotation for the camera
		Vector3 desiredPosition = target.position - target.forward * offset.z + Vector3.up * offset.y;
		Quaternion desiredRotation = Quaternion.LookRotation(target.position - transform.position, Vector3.up);

		// Smoothly move the camera to the desired position and rotation
		transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
		transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, smoothSpeed);
	}
}

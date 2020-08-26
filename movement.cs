using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ROSBridgeLib.std_msgs;
using ROSBridgeLib;
using SimpleJSON;
using ROSBridgeLib.geometry_msgs;


public class movement : MonoBehaviour
{
static GameObject cube;
public static Rigidbody rb;

 

  
public new static string GetMessageTopic() {
return "/force";}
  


public new static string GetMessageType() {
return "std_msgs/Float64";}
  

  // Important function (I think.. Converts json to PoseMsg)
  public new static ROSBridgeMsg ParseMessage(JSONNode msg) {
    return new Float64Msg (msg);}
  


		


  // This function should fire on each received ros message
public new static void CallBack(Float64Msg msg) {
double f=8;
double b=2;
double l=4;
double r=6;
double j=5;
  cube=GameObject.Find("cube");
     Debug.Log("msg"+msg.GetData());
if(msg.GetData()== f){
 Debug.Log("got:front commmand"  );
   cube.GetComponent<Rigidbody>().AddForce(0,0,500);}
if(msg.GetData()== b){
 Debug.Log("got:back command");
   cube.GetComponent<Rigidbody>().AddForce(0,0,-500);}
if(msg.GetData()== l){
 Debug.Log("got:left command" );
   cube.GetComponent<Rigidbody>().AddForce(-500,0,0);}
if(msg.GetData()== r){
 Debug.Log("got:right command");
   cube.GetComponent<Rigidbody>().AddForce(500,0,0);}
if(msg.GetData()== j){
 Debug.Log("got:jump command" );
   cube.GetComponent<Rigidbody>().AddForce(0,200,0);}




  }
}

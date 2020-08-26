#include<ros/ros.h>
#include<std_msgs/Float64.h>

int main(int argc ,char** argv)
{
   ros::init(argc, argv, "unity");
   ros::NodeHandle nh;
   ros:: Publisher pub = nh.advertise<std_msgs::Float64>("force",1000);
   std_msgs::Float64 msg;
   while(ros::ok())
{ 
   float val;
  std::cout<<"Write the commands";
  std::cin>>val;
  msg.data = val ;
  pub.publish(msg);
  ros::spinOnce();
  
}
  return 0;
}

>**2019/10/24,docker19.03.4, .netcore 3.0,CentOS7.6**   
>ժҪ��asp.net core 3.0 ��վ��Ŀ����������ʹ��docker-compose����Nginx������MySQL������web����    
>[��������](https://www.cnblogs.com/kasnti/p/11731899.html)   

�����ṹ����   

������վ��Ŀȡ��samplems��һ����Ҫ����������������˳�򣩣�   
1.MySQL������ȡ��Ϊ`samplems.mysql`������`mysql`���ٷ�������   
2.web������ȡ��Ϊ`samplems.web`������`samplemsweb`(�Լ�build������)����   
3.nginx������ȡ��Ϊ`samplems.nginx`������`nginx`(�ٷ�)����   
ʹ��docker-compose�������������������Ž����磨ȡ��`samplems-net`����ϵ����   
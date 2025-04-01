# Damn-Vulnerable-Catering-Application

## Main purpose

Damn Vulnerable Catering Application (DVCA) is a Thick Client Application developed in C# .NET. Main purpose of it is to serve as an exemplary application that can be used to learn how to pentest such solutions. 

Main idea was to create an application which would pretend to be an actual product with several hidden vulnerabilites. Main theme and all of the application's functionalities revolve around ordering catering, thus the name. Contained weaknesses are not highlighted in any way in order to simulate real-world case of pentesting thick client application. It is all for you to explore, test your tools and hack!

DVCA is a thick client application that was developed with three-tier network architecture in mind. That's why besides the client application, within this repository, you can find source code of the server which is as a middle-man between the client and the database itself. It's a simple CRUD API which is hosted locally. 

Some exemplary screenshots of the app:
![screen_1](https://github.com/user-attachments/assets/2d5e839c-1aa4-434e-aa49-aab41da80b42)
![screen_2](https://github.com/user-attachments/assets/d97afb4c-b438-4d48-9249-557ff246c4d7)

## Set-up guide

Of course you can compile and configure server and client app on your own, but for the sake of simplicity, I have uploaded already compiled application alongside with Docker image of the application's server to the Release section for this repository. It's all there alongside with instructions on how to set-up it and run. 

Small detail from my side if you want to compile the server yourself - please use the following command to build the Docker container (the "backend-webapp" matches the image name within docker-compose file). Command should be executed within the "Application Server" directory:
```docker build -t backend-webapp .```

### Happy hacking! 

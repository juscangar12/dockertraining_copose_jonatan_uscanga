# dockertraining_copose_jonatan_uscanga
COMMANDS:
cls

docker --version

docker ps

docker images

docker pull mysql

docker volume create database_container

docker run --name database_container -e MYSQL_RANDOM_ROOT_PASSWORD=yes -e MYSQL_DATABASE=Persons -e MYSQL_USER=admin -e MYSQL_PASSWORD=test -v db-test:/var/lib/mysql -p 3018:3306 -d mysql

dotnet ef migrations add Initial

docker build -f "E:\Develop\source\repos\dockertraining_copose_jonatan_uscanga\Dockerfile" --force-rm -t jonatan_uscanga_dockers_img "E:\Develop\source\repos\dockertraining_copose_jonatan_uscanga"

docker run --name jonatan_uscanga_dockers_app -p 8086:80 -e "ConnectionStrings:PersonDB"="Server=database_container;Port=3306;Database=Persons; Uid=admin; Pwd=test" --link database_container -it jonatan_uscanga_dockers_img

docker build -f "E:\Develop\source\repos\dockertraining_copose_jonatan_uscanga\Dockerfile" --force-rm -t jonatan_uscanga_dockers_img "E:\Develop\source\repos\dockertraining_copose_jonatan_uscanga"

docker images

docker tag a083f8d2f768 dockertraining2020/compose_jonatanuscanga:tagname

docker push dockertraining2020/compose_jonatanuscanga:tagname

-----------------------------------------------------------------------------------------------
Github link
https://github.com/juscangar12/dockertraining_copose_jonatan_uscanga

Docker Hub:
https://hub.docker.com/repository/docker/dockertraining2020/compose_jonatanuscanga

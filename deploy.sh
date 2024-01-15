# Creates docker image
docker build -t portfolio -f Dockerfile . 

# Rename docker image
docker tag portfolio:latest ntaticat/portfolio:latest

# Publish to Docker Hub
docker push ntaticat/portfolio 
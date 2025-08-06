
# Link of Code Repository
https://github.com/Vipul5/Docker_TeacherProject/

# Docker hub URL for docker images
https://hub.docker.com/repository/docker/vipulpatodi/teacher-api/
https://hub.docker.com/repository/docker/vipulpatodi/teacher-postgres/

# URL for Service API tier to view the records from backend tier.
http://<externalAPI>/teachers
http://34.44.135.23/teachers

# Video URL
https://nagarro-my.sharepoint.com/:v:/p/vipul_patodi/EZjoPxWi0c1Bv1W5bG4d6aIBufB-OLM9MxbZx9nMnXuC4A?nav=eyJyZWZlcnJhbEluZm8iOnsicmVmZXJyYWxBcHAiOiJPbmVEcml2ZUZvckJ1c2luZXNzIiwicmVmZXJyYWxBcHBQbGF0Zm9ybSI6IldlYiIsInJlZmVycmFsTW9kZSI6InZpZXciLCJyZWZlcnJhbFZpZXciOiJNeUZpbGVzTGlua0NvcHkifX0&e=joU5ev


# GKE Multi-Tier Teacher Application

This repository contains a multi-tier application consisting of a C# .NET Core API and a PostgreSQL database, designed for deployment on Google Kubernetes Engine (GKE).

---

## Project Overview

This project simulates a simple system where a .NET Core API fetches teacher data from a PostgreSQL database. Both components are containerized using Docker and orchestrated using Kubernetes on Google Cloud.

---

## Folder Structure

* `StudentAPI/`: Contains the C# .NET Core Web API project.
* `postgresql-docker/`: Contains the `Dockerfile` and `init.sql` for the PostgreSQL database.
* `k8s-manifests/`: Contains all Kubernetes YAML files for deploying the application on GKE.

---

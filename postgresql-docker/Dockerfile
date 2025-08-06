FROM postgres:16-alpine

COPY init.sql /docker-entrypoint-initdb.d/

EXPOSE 5432

ENV POSTGRES_DB teacherdb
ENV POSTGRES_USER postgres
ENV POSTGRES_PASSWORD Passw0rd
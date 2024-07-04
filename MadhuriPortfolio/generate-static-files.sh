#!/bin/bash

# Ensure output directory exists
OUTPUT_DIR="out/static"
mkdir -p $OUTPUT_DIR

# Copy static files (HTML, CSS, JS) to output directory
cp -r wwwroot/* $OUTPUT_DIR/
cp -r Views/* $OUTPUT_DIR/

#!/bin/bash

# Ensure output directory exists
OUTPUT_DIR="out/static"
mkdir -p $OUTPUT_DIR

# Copy static files (HTML, CSS, JS) to output directory
cp -r ./MadhuriPortfolio/wwwroot/* $OUTPUT_DIR/
cp -r ./MadhuriPortfolio/Views/* $OUTPUT_DIR/

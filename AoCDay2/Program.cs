﻿
int[][] matrix = new int[][]
{
    new int[] {6,8,9,11,14,12},
new int[] {31,33,36,39,42,42},
new int[] {5,6,7,9,11,13,17},
new int[] {7,9,12,15,17,18,21,27},
new int[] {58,59,60,59,60},
new int[] {59,60,57,60,61,63,61},
new int[] {68,70,71,70,72,75,76,76},
new int[] {17,18,19,21,23,22,25,29},
new int[] {56,57,60,58,64},
new int[] {10,11,12,12,15},
new int[] {87,90,93,96,97,98,98,96},
new int[] {40,41,44,44,45,46,46},
new int[] {72,75,75,78,79,83},
new int[] {77,80,80,81,88},
new int[] {43,45,48,49,50,54,56,58},
new int[] {50,51,54,58,57},
new int[] {44,45,47,51,51},
new int[] {46,47,50,54,57,60,63,67},
new int[] {12,15,17,21,24,29},
new int[] {82,83,86,92,95},
new int[] {18,21,26,29,27},
new int[] {68,71,72,74,76,83,83},
new int[] {7,10,17,20,22,26},
new int[] {30,31,37,38,45},
new int[] {24,21,22,24,25,26,27},
new int[] {34,31,33,34,32},
new int[] {4,3,5,6,8,10,13,13},
new int[] {18,17,20,23,25,29},
new int[] {29,27,29,30,37},
new int[] {61,58,61,58,59,62},
new int[] {65,62,63,60,63,65,67,65},
new int[] {13,11,13,12,12},
new int[] {25,23,20,23,26,29,31,35},
new int[] {58,55,52,54,61},
new int[] {24,22,25,25,26,27,29,31},
new int[] {25,22,23,24,27,27,24},
new int[] {10,8,8,9,9},
new int[] {64,63,66,66,70},
new int[] {72,71,74,74,77,83},
new int[] {89,86,89,92,96,99},
new int[] {89,87,88,92,93,96,97,95},
new int[] {87,85,88,92,93,93},
new int[] {77,74,78,79,82,84,88},
new int[] {42,39,42,43,47,53},
new int[] {79,76,79,82,88,89,90,92},
new int[] {58,56,59,61,63,70,72,69},
new int[] {42,40,41,46,47,47},
new int[] {55,53,56,58,64,65,69},
new int[] {46,43,45,50,52,57},
new int[] {67,67,68,69,70,73,74,75},
new int[] {61,61,63,65,62},
new int[] {24,24,27,30,32,32},
new int[] {30,30,31,32,33,36,40},
new int[] {40,40,43,45,48,50,55},
new int[] {62,62,64,66,64,66,67},
new int[] {88,88,90,93,94,95,94,93},
new int[] {88,88,85,88,89,90,90},
new int[] {69,69,70,73,75,72,73,77},
new int[] {10,10,7,10,12,17},
new int[] {12,12,14,15,15,17,20},
new int[] {14,14,16,17,19,19,22,20},
new int[] {7,7,8,8,11,11},
new int[] {89,89,92,93,94,94,98},
new int[] {85,85,86,89,89,96},
new int[] {70,70,74,77,79},
new int[] {86,86,90,93,94,93},
new int[] {26,26,29,30,32,36,36},
new int[] {85,85,86,90,94},
new int[] {35,35,36,40,46},
new int[] {61,61,68,70,72,73},
new int[] {71,71,74,76,79,80,87,86},
new int[] {88,88,89,92,99,99},
new int[] {22,22,28,30,32,35,39},
new int[] {11,11,13,19,24},
new int[] {4,8,9,11,12,15},
new int[] {13,17,20,23,26,29,26},
new int[] {64,68,70,71,74,74},
new int[] {80,84,85,88,90,91,94,98},
new int[] {71,75,76,78,81,83,86,93},
new int[] {34,38,41,43,40,41,43,45},
new int[] {2,6,5,8,10,9},
new int[] {25,29,31,29,29},
new int[] {64,68,69,72,69,73},
new int[] {19,23,25,24,25,32},
new int[] {65,69,69,70,71,72,75},
new int[] {84,88,91,91,94,96,97,95},
new int[] {86,90,93,93,93},
new int[] {30,34,36,37,40,40,44},
new int[] {69,73,76,78,78,79,84},
new int[] {79,83,85,89,90,93,95},
new int[] {4,8,11,12,16,13},
new int[] {19,23,26,30,32,33,36,36},
new int[] {23,27,28,29,33,34,38},
new int[] {10,14,18,20,21,26},
new int[] {26,30,32,38,41},
new int[] {61,65,72,74,75,76,74},
new int[] {35,39,41,46,47,48,48},
new int[] {35,39,40,41,43,46,53,57},
new int[] {57,61,68,70,75},
new int[] {80,86,87,89,91,93},
new int[] {59,64,67,68,71,69},
new int[] {33,38,41,43,43},
new int[] {55,60,61,64,65,66,67,71},
new int[] {41,48,50,51,52,57},
new int[] {43,50,53,56,55,57,60,63},
new int[] {89,94,96,99,96,97,99,98},
new int[] {11,16,18,21,23,26,23,23},
new int[] {54,61,64,66,67,66,70},
new int[] {28,34,35,37,36,38,40,45},
new int[] {47,54,55,58,60,60,62,64},
new int[] {77,84,87,89,90,90,92,90},
new int[] {21,26,27,27,29,29},
new int[] {50,55,58,58,60,62,64,68},
new int[] {10,17,18,20,20,27},
new int[] {8,14,18,19,22,23,25,27},
new int[] {31,38,41,42,46,49,48},
new int[] {58,64,66,70,73,76,76},
new int[] {26,32,35,38,42,46},
new int[] {61,68,72,75,80},
new int[] {21,26,28,30,33,38,39},
new int[] {30,36,38,44,46,49,47},
new int[] {2,7,8,14,14},
new int[] {39,44,47,49,52,59,62,66},
new int[] {64,71,73,80,85},
new int[] {76,75,74,72,73},
new int[] {54,52,49,47,44,42,41,41},
new int[] {87,84,82,81,78,76,72},
new int[] {62,59,58,57,54,52,49,43},
new int[] {94,92,89,86,89,88},
new int[] {71,70,72,69,70},
new int[] {50,49,48,51,49,46,46},
new int[] {35,34,31,34,30},
new int[] {20,19,18,21,18,12},
new int[] {95,93,90,90,89,88},
new int[] {50,47,45,44,42,42,45},
new int[] {59,57,55,55,54,51,51},
new int[] {54,51,51,48,46,45,41},
new int[] {93,90,88,87,85,85,80},
new int[] {20,17,14,10,9,7,4},
new int[] {90,89,88,85,84,80,81},
new int[] {43,41,37,36,33,33},
new int[] {97,94,90,87,86,82},
new int[] {15,13,9,8,2},
new int[] {88,86,84,82,75,74,72,69},
new int[] {64,63,58,56,54,57},
new int[] {12,10,5,3,2,2},
new int[] {65,63,61,60,59,54,50},
new int[] {44,41,36,33,28},
new int[] {80,82,81,80,77,76,73,72},
new int[] {78,81,79,77,78},
new int[] {21,24,23,22,21,19,16,16},
new int[] {72,73,70,68,65,61},
new int[] {27,30,28,25,24,23,18},
new int[] {48,50,49,47,50,48,47},
new int[] {93,96,99,96,99},
new int[] {14,16,15,16,13,10,7,7},
new int[] {77,79,77,74,77,76,72},
new int[] {57,59,56,58,56,54,47},
new int[] {74,77,75,75,72},
new int[] {20,22,20,18,17,17,14,15},
new int[] {57,59,58,56,56,56},
new int[] {41,43,42,40,38,38,35,31},
new int[] {96,98,97,96,96,95,88},
new int[] {56,58,57,53,50,48},
new int[] {76,77,75,71,73},
new int[] {82,84,80,77,74,73,70,70},
new int[] {66,67,66,62,58},
new int[] {46,47,43,41,39,33},
new int[] {58,60,59,57,51,50,48},
new int[] {64,65,62,55,52,53},
new int[] {37,38,37,31,29,26,26},
new int[] {43,44,39,38,35,31},
new int[] {79,80,75,73,67},
new int[] {37,37,34,33,30,28},
new int[] {65,65,64,63,62,63},
new int[] {60,60,59,58,56,56},
new int[] {83,83,81,78,76,74,73,69},
new int[] {23,23,20,18,13},
new int[] {10,10,13,12,10},
new int[] {69,69,68,69,67,66,67},
new int[] {13,13,11,14,13,10,8,8},
new int[] {78,78,75,77,76,73,72,68},
new int[] {79,79,76,73,75,69},
new int[] {89,89,89,88,86,84,82,81},
new int[] {62,62,59,59,56,57},
new int[] {80,80,77,76,76,76},
new int[] {99,99,97,94,94,90},
new int[] {62,62,59,56,53,53,48},
new int[] {69,69,65,62,61,59,58},
new int[] {13,13,12,11,8,4,5},
new int[] {69,69,67,66,64,60,60},
new int[] {56,56,53,52,48,44},
new int[] {61,61,57,56,50},
new int[] {61,61,60,59,53,51},
new int[] {82,82,81,78,77,70,67,69},
new int[] {90,90,88,85,79,77,77},
new int[] {91,91,86,85,81},
new int[] {25,25,23,20,17,12,11,5},
new int[] {15,11,8,7,6,4},
new int[] {34,30,29,28,26,25,22,24},
new int[] {29,25,24,21,20,17,14,14},
new int[] {50,46,44,41,40,36},
new int[] {52,48,46,43,38},
new int[] {73,69,71,68,66,63,62,60},
new int[] {45,41,38,37,36,37,39},
new int[] {85,81,79,78,79,79},
new int[] {38,34,33,31,32,30,29,25},
new int[] {80,76,74,75,68},
new int[] {48,44,44,41,39,37,34},
new int[] {46,42,39,36,35,35,32,33},
new int[] {61,57,54,52,52,50,50},
new int[] {63,59,57,56,56,52},
new int[] {31,27,26,26,23,18},
new int[] {42,38,34,33,32,29,27},
new int[] {37,33,31,28,25,21,18,21},
new int[] {57,53,50,46,46},
new int[] {24,20,18,14,13,9},
new int[] {73,69,68,65,64,61,57,50},
new int[] {74,70,68,65,64,63,57,54},
new int[] {89,85,84,78,80},
new int[] {54,50,44,42,42},
new int[] {31,27,22,19,15},
new int[] {35,31,24,22,20,17,10},
new int[] {65,58,57,55,54},
new int[] {36,31,30,29,27,26,29},
new int[] {30,23,20,19,19},
new int[] {27,22,21,20,16},
new int[] {74,68,67,64,62,55},
new int[] {12,5,3,6,5},
new int[] {54,48,51,49,46,44,45},
new int[] {24,18,19,16,13,13},
new int[] {28,22,19,22,19,18,14},
new int[] {61,55,52,53,48},
new int[] {88,82,80,80,78,75,73},
new int[] {93,87,86,86,87},
new int[] {18,11,8,8,5,3,2,2},
new int[] {87,80,79,78,77,77,73},
new int[] {47,41,40,40,33},
new int[] {96,89,85,83,82},
new int[] {56,51,50,46,44,47},
new int[] {82,76,74,70,68,66,65,65},
new int[] {41,36,33,31,27,25,23,19},
new int[] {77,72,70,66,63,61,56},
new int[] {48,41,40,34,31,30},
new int[] {80,74,69,66,65,63,65},
new int[] {55,50,44,43,40,38,35,35},
new int[] {81,74,71,69,66,59,56,52},
new int[] {56,51,48,43,36},
new int[] {55,58,59,62,65,68,69,68},
new int[] {79,82,85,88,90,92,94,94},
new int[] {62,63,65,67,70,74},
new int[] {51,53,56,59,60,67},
new int[] {42,43,41,43,44},
new int[] {46,48,49,52,53,54,52,49},
new int[] {79,81,82,79,82,82},
new int[] {16,18,19,18,21,24,28},
new int[] {32,33,35,37,40,39,40,45},
new int[] {18,19,19,21,22,24,27},
new int[] {5,8,10,10,12,9},
new int[] {53,55,58,58,60,61,62,62},
new int[] {83,85,88,90,91,94,94,98},
new int[] {31,32,34,35,35,38,41,48},
new int[] {11,12,16,17,20,21,23,24},
new int[] {22,25,29,30,31,32,29},
new int[] {57,59,61,65,65},
new int[] {39,41,42,46,49,52,56},
new int[] {37,38,42,44,50},
new int[] {38,40,43,46,53,54},
new int[] {59,62,68,70,68},
new int[] {29,30,37,38,39,39},
new int[] {74,75,76,83,87},
new int[] {36,39,46,48,51,57},
new int[] {38,35,36,39,41,43},
new int[] {9,7,10,12,9},
new int[] {49,46,48,49,50,50},
new int[] {53,52,55,56,57,58,62},
new int[] {50,48,51,54,61},
new int[] {88,87,88,90,92,89,91},
new int[] {82,80,83,85,84,81},
new int[] {77,75,74,75,77,77},
new int[] {18,15,17,19,17,20,24},
new int[] {70,69,71,69,71,73,78},
new int[] {10,7,9,10,12,12,14,16},
new int[] {74,73,76,78,78,80,78},
new int[] {44,42,42,44,44},
new int[] {80,79,79,80,84},
new int[] {62,59,61,62,64,65,65,70},
new int[] {5,4,8,9,12,13},
new int[] {79,78,82,83,81},
new int[] {72,70,71,75,77,80,80},
new int[] {11,9,12,14,18,22},
new int[] {51,48,52,53,60},
new int[] {65,64,67,72,75},
new int[] {61,58,61,62,69,72,70},
new int[] {41,38,41,42,48,49,51,51},
new int[] {61,60,62,69,71,75},
new int[] {10,9,15,17,18,24},
new int[] {60,60,63,64,65},
new int[] {66,66,68,70,71,70},
new int[] {51,51,53,56,58,61,62,62},
new int[] {43,43,46,49,53},
new int[] {78,78,79,81,83,86,88,93},
new int[] {69,69,70,73,76,78,75,77},
new int[] {1,1,3,5,6,7,6,5},
new int[] {41,41,40,43,43},
new int[] {51,51,53,51,55},
new int[] {57,57,55,56,61},
new int[] {82,82,83,84,86,86,88},
new int[] {89,89,92,92,91},
new int[] {66,66,69,69,69},
new int[] {69,69,71,74,75,75,77,81},
new int[] {41,41,41,44,47,50,51,57},
new int[] {12,12,15,19,20},
new int[] {57,57,61,63,60},
new int[] {53,53,56,59,63,63},
new int[] {36,36,40,41,45},
new int[] {82,82,86,88,89,90,95},
new int[] {23,23,25,26,32,35},
new int[] {77,77,78,79,85,82},
new int[] {70,70,72,79,80,80},
new int[] {32,32,34,35,40,44},
new int[] {66,66,67,69,72,75,82,88},
new int[] {79,83,85,87,89,90,91},
new int[] {80,84,85,88,86},
new int[] {90,94,97,99,99},
new int[] {71,75,76,78,82},
new int[] {14,18,20,23,25,28,35},
new int[] {42,46,49,46,48,49,51},
new int[] {72,76,77,74,77,80,81,78},
new int[] {34,38,36,39,39},
new int[] {71,75,74,76,78,82},
new int[] {34,38,39,41,40,43,46,51},
new int[] {48,52,52,53,56,57,60,62},
new int[] {66,70,71,74,74,72},
new int[] {53,57,57,59,60,63,63},
new int[] {52,56,58,58,62},
new int[] {5,9,12,12,15,16,19,25},
new int[] {32,36,39,43,45},
new int[] {18,22,25,26,28,32,33,32},
new int[] {21,25,26,30,30},
new int[] {47,51,54,58,60,64},
new int[] {70,74,75,76,79,83,90},
new int[] {36,40,46,49,52,55},
new int[] {59,63,66,68,74,76,74},
new int[] {53,57,58,59,61,62,69,69},
new int[] {33,37,39,45,49},
new int[] {35,39,46,49,51,52,55,61},
new int[] {32,39,42,44,47,50},
new int[] {69,74,77,80,83,81},
new int[] {11,16,19,22,25,27,27},
new int[] {58,63,66,68,70,74},
new int[] {37,43,46,47,50,52,53,58},
new int[] {84,89,88,91,92,95,97,99},
new int[] {62,69,71,74,71,74,71},
new int[] {4,10,8,9,11,14,14},
new int[] {60,66,65,67,71},
new int[] {39,46,45,46,47,52},
new int[] {6,12,13,13,14,17},
new int[] {36,42,42,45,44},
new int[] {6,11,13,13,16,19,20,20},
new int[] {34,41,41,44,45,49},
new int[] {78,85,88,88,94},
new int[] {72,78,81,85,86,89,91,94},
new int[] {51,57,59,62,66,67,64},
new int[] {51,57,59,61,65,67,67},
new int[] {19,25,29,30,32,36},
new int[] {44,50,51,55,57,64},
new int[] {45,50,52,59,61},
new int[] {12,17,20,23,26,29,34,31},
new int[] {35,41,44,46,51,51},
new int[] {28,34,35,38,40,42,48,52},
new int[] {31,38,44,45,46,48,51,58},
new int[] {74,72,70,69,66,63,62,64},
new int[] {78,75,73,71,71},
new int[] {66,65,63,62,60,56},
new int[] {54,52,49,48,45,42,36},
new int[] {65,62,61,59,57,58,56,54},
new int[] {15,12,10,7,5,6,7},
new int[] {26,25,23,21,23,20,20},
new int[] {31,30,29,28,29,28,24},
new int[] {35,33,31,34,31,28,25,19},
new int[] {12,9,7,4,4,3,2},
new int[] {99,97,95,92,91,91,88,90},
new int[] {99,96,96,94,94},
new int[] {45,42,42,39,36,35,31},
new int[] {50,48,48,45,43,41,39,33},
new int[] {88,85,81,78,77,76,74},
new int[] {28,27,25,21,19,18,17,19},
new int[] {30,28,27,25,23,19,19},
new int[] {43,40,38,34,31,28,24},
new int[] {24,21,20,19,18,17,13,8},
new int[] {40,39,33,31,29,26,23},
new int[] {26,25,23,16,15,13,11,14},
new int[] {35,34,28,27,27},
new int[] {17,16,10,7,3},
new int[] {43,40,35,34,31,28,25,18},
new int[] {48,50,47,46,44,41,39,38},
new int[] {30,32,31,28,26,27},
new int[] {55,56,54,52,51,48,48},
new int[] {47,48,45,44,41,38,36,32},
new int[] {35,36,33,30,23},
new int[] {47,48,46,45,44,45,44,41},
new int[] {20,23,22,21,18,15,16,19},
new int[] {64,67,70,68,66,66},
new int[] {47,50,53,52,51,50,48,44},
new int[] {32,34,35,32,29,28,23},
new int[] {44,47,45,45,44},
new int[] {24,27,27,24,25},
new int[] {86,88,85,85,85},
new int[] {12,14,14,13,12,10,7,3},
new int[] {72,75,72,72,71,68,63},
new int[] {97,99,98,96,95,94,90,88},
new int[] {41,42,39,38,35,33,29,32},
new int[] {11,14,11,10,6,5,5},
new int[] {76,78,75,72,69,65,61},
new int[] {14,15,12,8,2},
new int[] {54,57,54,52,47,46},
new int[] {51,54,52,49,46,45,40,43},
new int[] {15,18,15,8,8},
new int[] {87,90,88,86,84,77,75,71},
new int[] {77,80,79,73,72,71,66},
new int[] {23,23,21,18,15,14},
new int[] {81,81,78,76,79},
new int[] {28,28,26,23,21,18,18},
new int[] {35,35,33,31,28,27,25,21},
new int[] {97,97,94,92,89,87,86,80},
new int[] {3,3,5,4,2},
new int[] {72,72,71,74,72,75},
new int[] {44,44,43,40,41,39,37,37},
new int[] {44,44,41,38,39,38,34},
new int[] {90,90,89,92,90,84},
new int[] {42,42,42,39,37,35,34},
new int[] {61,61,61,59,57,56,57},
new int[] {96,96,95,95,93,90,87,87},
new int[] {91,91,90,88,86,86,84,80},
new int[] {88,88,88,86,85,84,82,76},
new int[] {99,99,95,94,92},
new int[] {58,58,55,54,50,53},
new int[] {17,17,13,11,11},
new int[] {51,51,48,47,43,40,38,34},
new int[] {92,92,88,85,82,77},
new int[] {94,94,87,86,85},
new int[] {15,15,13,11,10,4,7},
new int[] {70,70,65,64,63,61,61},
new int[] {55,55,49,46,42},
new int[] {84,84,83,82,76,75,74,68},
new int[] {55,51,48,45,42,40,37},
new int[] {14,10,9,7,4,1,4},
new int[] {33,29,26,23,22,21,21},
new int[] {58,54,51,50,46},
new int[] {17,13,10,8,3},
new int[] {73,69,66,63,61,63,60,59},
new int[] {35,31,29,30,31},
new int[] {25,21,18,19,18,16,16},
new int[] {72,68,71,70,69,65},
new int[] {78,74,76,73,72,65},
new int[] {86,82,80,79,76,76,75,74},
new int[] {19,15,14,14,12,13},
new int[] {86,82,80,80,78,75,75},
new int[] {42,38,36,36,33,29},
new int[] {47,43,43,41,38,35,33,26},
new int[] {86,82,80,76,73,71,68},
new int[] {62,58,56,52,51,48,47,50},
new int[] {62,58,56,54,50,47,47},
new int[] {20,16,15,14,10,9,5},
new int[] {49,45,41,39,37,36,33,26},
new int[] {51,47,46,45,39,36,34,32},
new int[] {90,86,85,79,80},
new int[] {25,21,19,17,10,8,6,6},
new int[] {29,25,22,15,11},
new int[] {62,58,57,54,49,44},
new int[] {68,63,61,59,56,55},
new int[] {47,41,39,38,37,35,37},
new int[] {45,38,35,32,29,27,26,26},
new int[] {84,77,74,71,68,64},
new int[] {43,38,35,32,31,26},
new int[] {25,19,17,16,17,16,13,10},
new int[] {68,61,59,58,56,58,55,58},
new int[] {54,47,46,43,46,44,43,43},
new int[] {40,33,32,29,32,29,28,24},
new int[] {77,70,69,72,71,69,66,61},
new int[] {53,47,47,45,43,41,38},
new int[] {80,75,72,71,71,69,72},
new int[] {40,33,30,27,27,24,23,23},
new int[] {22,16,13,13,9},
new int[] {26,20,20,18,15,9},
new int[] {55,48,45,41,38,36},
new int[] {23,18,17,13,10,9,8,10},
new int[] {25,19,15,12,12},
new int[] {40,33,32,31,29,27,23,19},
new int[] {93,88,84,81,78,73},
new int[] {72,65,59,58,55,54,51,49},
new int[] {64,58,52,49,52},
new int[] {49,43,40,33,32,29,29},
new int[] {63,57,56,54,47,43},
new int[] {82,77,74,68,66,60},
new int[] {58,55,53,46,46},
new int[] {75,80,82,84,83,85,85},
new int[] {23,19,21,20,17,14,14},
new int[] {77,81,85,86,87,88,95},
new int[] {47,41,39,37,36,37,31},
new int[] {84,77,70,69,72},
new int[] {82,81,79,76,76},
new int[] {84,84,87,88,85,88,90},
new int[] {76,74,72,70,67,70,68},
new int[] {85,86,84,82,76,74,71,67},
new int[] {87,87,84,83,82,78,74},
new int[] {5,4,7,10,13,18,19},
new int[] {7,5,7,4,5},
new int[] {77,77,75,74,70},
new int[] {73,69,66,63,60,59,56},
new int[] {41,41,43,46,49,50,53,53},
new int[] {46,50,52,54,54,56,60},
new int[] {64,64,65,71,74},
new int[] {52,55,52,50,48,45,42,44},
new int[] {39,36,37,44,46,45},
new int[] {59,55,54,52,48,45,41},
new int[] {85,82,81,82,80,77,76,72},
new int[] {61,56,54,51,48,45,44,40},
new int[] {78,77,74,72,74,76},
new int[] {8,13,17,18,21},
new int[] {37,37,34,32,33},
new int[] {46,44,45,48,49,55,55},
new int[] {74,75,79,80,82,84,86,90},
new int[] {86,82,82,80,79,76,74},
new int[] {61,68,70,72,74,72},
new int[] {9,9,13,15,22},
new int[] {39,38,39,39,43},
new int[] {2,9,7,10,14},
new int[] {16,15,14,10,12},
new int[] {33,37,44,46,48},
new int[] {39,35,31,28,28},
new int[] {61,61,63,64,64,65,65},
new int[] {67,60,58,55,54,52,51,50},
new int[] {69,70,68,67,68,65,62},
new int[] {42,41,38,37,37,35,33,29},
new int[] {64,66,70,73,76,79,80},
new int[] {18,22,23,25,26,29,36},
new int[] {37,36,29,28,26,25,26},
new int[] {52,45,43,39,38,36,38},
new int[] {51,56,57,63,65,67,69,75},
new int[] {16,17,14,10,8,10},
new int[] {20,14,14,12,9,6},
new int[] {25,21,19,18,18,16,14,9},
new int[] {40,40,37,35,34,33,31,24},
new int[] {40,42,47,49,52,52},
new int[] {72,73,72,68,66},
new int[] {95,92,91,88,87,84,80},
new int[] {76,75,74,72,70,68,64,60},
new int[] {49,49,50,53,55,58,61,68},
new int[] {50,56,59,62,66,68,69,69},
new int[] {85,85,83,84,87,90,94},
new int[] {21,22,18,17,11},
new int[] {37,40,38,41,47},
new int[] {18,19,16,13,10,10},
new int[] {45,46,52,53,54,55,57,61},
new int[] {2,5,5,8,11,9},
new int[] {42,38,37,40,41},
new int[] {28,25,23,25,22,17},
new int[] {53,54,52,50,47,50,46},
new int[] {18,22,25,26,27,27},
new int[] {62,61,60,63,63},
new int[] {30,30,31,38,41,41},
new int[] {97,97,95,94,93,90,88},
new int[] {32,33,31,25,24,21,20},
new int[] {41,43,46,46,47,49},
new int[] {25,24,27,29,31,32,34},
new int[] {2,4,3,4,7,7},
new int[] {26,23,21,19,17,17,16},
new int[] {59,62,64,67,70,74,74},
new int[] {62,62,60,57,50,49,47,48},
new int[] {49,46,45,40,33},
new int[] {44,38,36,37,37},
new int[] {87,81,79,79,76,76},
new int[] {7,14,17,19,19},
new int[] {80,82,78,77,74,72,68},
new int[] {5,9,11,13,19,21,21},
new int[] {38,40,42,44,50,52,57},
new int[] {74,78,79,81,83,82,84,89},
new int[] {91,94,93,88,89},
new int[] {24,28,31,33,36,39,44,43},
new int[] {26,24,21,16,12},
new int[] {86,82,81,75,73,71,69,69},
new int[] {25,25,26,28,25},
new int[] {80,79,83,86,87},
new int[] {69,68,71,73,76,79,81,85},
new int[] {18,16,19,22,22,24,31},
new int[] {55,58,54,53,50,47,44,44},
new int[] {37,31,30,24,23,23},
new int[] {16,19,17,17,13},
new int[] {58,56,55,54,54,51,51},
new int[] {73,73,76,77,76,74},
new int[] {21,24,21,18,13},
new int[] {71,76,79,81,81,83,82},
new int[] {37,39,38,38,35,34,32,26},
new int[] {79,79,78,76,73,66,62},
new int[] {46,44,45,47,48,53,54,58},
new int[] {53,55,56,62,63,62},
new int[] {20,23,20,18,18,18},
new int[] {69,69,67,65,68,65,61},
new int[] {50,50,51,51,56},
new int[] {82,85,85,84,83,81,82},
new int[] {71,67,70,69,66,65,62,55},
new int[] {52,45,43,40,39,36,32,31},
new int[] {86,89,91,93,93,96,96},
new int[] {71,70,69,66,66,65,59},
new int[] {13,13,10,9,8,8,4},
new int[] {26,30,34,37,39},
new int[] {38,41,39,36,33,30,30,29},
new int[] {27,26,30,33,36,37,42},
new int[] {34,36,34,32,31,29,30,33},
new int[] {31,31,33,34,38,39,41,44},
new int[] {98,92,92,90,87,88},
new int[] {34,33,31,30,28,25,21,21},
new int[] {77,71,73,71,69,65},
new int[] {61,61,61,64,67,69,72},
new int[] {64,68,70,71,72,75},
new int[] {29,22,18,17,16,9},
new int[] {43,46,49,52,56,55},
new int[] {27,20,19,17,20},
new int[] {51,47,44,43,40,36},
new int[] {77,74,71,68,67,66,67},
new int[] {46,52,55,57,61,62,63,61},
new int[] {84,80,75,73,71,69,67,63},
new int[] {63,63,66,63,63},
new int[] {55,62,67,69,71,73,76,77},
new int[] {82,81,84,86,88,91,90},
new int[] {73,77,80,83,84,85,83,87},
new int[] {47,50,47,40,37,35,32,25},
new int[] {73,73,67,66,66},
new int[] {90,90,93,92,90,91},
new int[] {53,48,45,42,39,36,37,39},
new int[] {51,47,41,40,39,36,30},
new int[] {60,64,65,67,71,74,74},
new int[] {25,27,29,29,33},
new int[] {33,33,34,40,44},
new int[] {68,73,74,75,79,83},
new int[] {20,23,20,18,15},
new int[] {12,15,17,19,21,21,23,29},
new int[] {21,23,26,29,31,32,32},
new int[] {86,86,84,86,86},
new int[] {22,19,16,18,21,23,20},
new int[] {30,31,28,26,22},
new int[] {98,94,89,86,84},
new int[] {6,11,13,10,16},
new int[] {84,87,84,83,84,81,79,73},
new int[] {39,35,34,34,33,32,30,31},
new int[] {54,48,46,43,40,38,38},
new int[] {9,13,11,13,15},
new int[] {7,8,9,12,14,16,17,23},
new int[] {27,27,30,32,33,36,38,42},
new int[] {61,56,53,54,51},
new int[] {21,18,20,21,24,30},
new int[] {84,88,88,90,92,94,96,96},
new int[] {66,66,64,61,60,60},
new int[] {52,52,54,54,58},
new int[] {68,64,63,59,58,57,52},
new int[] {70,70,65,62,60},
new int[] {55,48,47,45,39,32},
new int[] {46,53,54,55,58,62},
new int[] {64,64,64,63,60,53},
new int[] {60,66,69,71,74,77,82,82},
new int[] {6,11,12,10,7},
new int[] {9,10,7,4,6,6},
new int[] {11,9,12,16,15},
new int[] {75,72,72,75,75},
new int[] {55,55,52,49,45,43,40,39},
new int[] {27,33,35,36,39,45,49},
new int[] {61,61,54,53,47},
new int[] {92,91,92,95,95,94},
new int[] {35,35,37,39,43,43},
new int[] {28,23,22,20,18,18,11},
new int[] {38,42,45,48,47},
new int[] {5,7,9,11,17,19,22},
new int[] {48,44,42,41,40,41,39,35},
new int[] {38,38,37,33,36},
new int[] {69,65,65,63,61,60,56},
new int[] {28,25,26,25,28,32},
new int[] {25,23,26,30,34},
new int[] {57,57,58,63,65,67,64},
new int[] {42,43,45,47,44,45,46,50},
new int[] {48,44,41,39,39},
new int[] {71,65,59,56,54,52,51,47},
new int[] {11,8,7,7,10},
new int[] {59,56,55,57,54,51,50,50},
new int[] {66,65,70,72,73,75,78,85},
new int[] {34,37,39,42,43,45,46},
new int[] {67,64,61,58,55,54,51,50},
new int[] {1,3,5,7,9,10},
new int[] {87,90,92,94,97},
new int[] {48,50,51,54,55,58,59},
new int[] {43,45,46,48,50},
new int[] {35,32,30,28,27},
new int[] {57,55,54,53,52},
new int[] {52,54,55,57,60,63},
new int[] {34,37,38,39,40,41,44},
new int[] {75,78,81,84,86,88,90,93},
new int[] {59,58,56,53,52,49,47},
new int[] {23,26,27,28,29,30,32},
new int[] {29,30,33,34,37,38,39},
new int[] {50,48,46,44,43,42,39},
new int[] {13,11,9,6,5},
new int[] {70,72,74,76,79,81},
new int[] {18,21,24,25,26},
new int[] {21,18,15,12,10,9},
new int[] {62,60,57,56,55},
new int[] {13,11,8,7,6,5},
new int[] {40,38,37,36,35},
new int[] {47,50,52,55,57,59,60},
new int[] {76,74,71,70,67,64,61},
new int[] {39,40,43,46,49,52,55,56},
new int[] {85,87,89,90,92},
new int[] {35,33,32,30,27,25,24,23},
new int[] {64,63,60,58,55,52,51},
new int[] {82,80,78,76,73,71},
new int[] {78,80,83,85,87,88,90,91},
new int[] {40,39,38,35,34,33},
new int[] {24,22,21,19,18,17,16},
new int[] {14,17,18,21,23},
new int[] {34,35,37,38,40,41,44,47},
new int[] {97,96,93,92,90,88},
new int[] {71,74,76,77,80,82},
new int[] {54,57,59,60,63},
new int[] {32,30,29,28,26},
new int[] {41,38,36,33,32,30,28},
new int[] {68,71,74,76,77,80},
new int[] {73,71,69,67,64,62,59,56},
new int[] {82,84,85,88,90},
new int[] {38,39,40,42,44,47,49,52},
new int[] {92,89,86,84,81,80},
new int[] {61,62,64,67,69},
new int[] {35,32,30,28,26,24,23,22},
new int[] {14,16,18,19,22,25,28},
new int[] {67,68,69,72,75,76,77,80},
new int[] {29,28,27,25,22,19},
new int[] {14,13,12,9,7,6},
new int[] {22,24,27,28,30,33},
new int[] {64,65,68,69,70,73,75,77},
new int[] {66,65,63,60,59,56},
new int[] {73,74,77,78,81},
new int[] {12,13,16,17,20},
new int[] {45,48,50,51,54,57,60,63},
new int[] {45,43,41,38,35,33,30},
new int[] {61,58,56,55,52,50},
new int[] {61,59,56,53,50,49,46},
new int[] {40,42,44,45,48,49,50,52},
new int[] {75,77,80,81,83,85},
new int[] {14,17,18,20,21,23,25},
new int[] {13,12,9,8,7},
new int[] {55,52,51,50,47,44,42},
new int[] {64,63,60,59,56,54,53,52},
new int[] {19,18,17,16,13,12,10,7},
new int[] {99,97,94,91,89,86,83,80},
new int[] {85,86,87,90,93,94,95,98},
new int[] {16,19,20,23,25,26,27},
new int[] {14,13,10,9,7},
new int[] {83,82,79,77,76,74,71,69},
new int[] {84,83,82,80,78,76},
new int[] {20,21,24,26,29,30,31},
new int[] {84,83,80,78,77,76,75},
new int[] {32,34,35,36,38},
new int[] {12,13,15,18,19,22,23,25},
new int[] {56,53,52,49,46,43,42,40},
new int[] {72,71,69,67,64,61,58,56},
new int[] {33,36,38,39,40,43},
new int[] {5,7,8,10,12,15,17,19},
new int[] {40,42,43,46,49,52,53,55},
new int[] {35,34,31,30,29,27,26,25},
new int[] {32,33,35,36,37,40,41,43},
new int[] {56,59,60,61,64,65,66},
new int[] {55,58,60,62,64,65,68,71},
new int[] {24,25,27,29,30,31,33,36},
new int[] {97,95,92,89,88,85,83,81},
new int[] {27,30,32,34,35,36},
new int[] {17,18,21,22,25},
new int[] {52,50,48,47,44,42,40,39},
new int[] {5,7,10,11,13,16},
new int[] {65,66,68,69,72,73,76,79},
new int[] {72,71,68,67,64,61,59,57},
new int[] {57,60,61,62,63,65,67},
new int[] {86,85,84,82,80,79,76,74},
new int[] {36,33,31,28,27,25,23},
new int[] {21,22,23,26,29,31},
new int[] {35,36,39,41,43,44,46},
new int[] {73,70,67,64,63,61,58},
new int[] {37,34,31,30,29,27},
new int[] {69,72,75,78,79,81,82,83},
new int[] {38,37,35,33,32,29,26,23},
new int[] {60,59,58,55,54,53},
new int[] {54,53,50,49,48,46,45},
new int[] {86,87,90,93,94,96,98},
new int[] {99,98,97,94,93,91},
new int[] {47,46,44,43,40},
new int[] {38,40,42,44,47,49},
new int[] {86,88,90,93,96},
new int[] {34,31,30,29,26},
new int[] {43,46,47,50,51,54},
new int[] {56,58,61,64,66,68,70,72},
new int[] {62,65,67,69,72,75,78},
new int[] {13,16,19,22,23,24,26},
new int[] {78,80,81,82,85,87,89},
new int[] {36,34,32,30,29,27,25,22},
new int[] {36,35,34,31,30,28,25,24},
new int[] {77,76,75,73,70,68,67},
new int[] {20,17,15,12,10,9,6,4},
new int[] {67,70,73,75,77},
new int[] {52,55,57,58,60,63,66},
new int[] {27,28,31,34,35},
new int[] {17,18,21,23,26,29,30,33},
new int[] {40,39,36,33,32,29,26},
new int[] {11,8,7,5,2},
new int[] {4,6,8,11,14,15},
new int[] {94,92,89,87,84,83,80},
new int[] {72,73,75,76,79,81,82,84},
new int[] {26,29,32,34,37,38},
new int[] {19,16,13,11,10,9,8},
new int[] {79,82,85,87,89},
new int[] {22,25,28,30,31,33,34,37},
new int[] {89,86,83,82,81},
new int[] {53,54,57,58,61,63},
new int[] {88,85,84,83,82,79,77},
new int[] {33,36,38,39,42,44},
new int[] {37,39,40,41,44},
new int[] {13,11,9,6,3},
new int[] {25,26,29,30,32,34,36},
new int[] {32,34,36,39,40,43,44,45},
new int[] {26,24,21,19,18},
new int[] {62,60,58,56,53,51,49,48},
new int[] {37,35,33,30,27,25,22,21},
new int[] {11,12,15,18,19,20},
new int[] {87,85,82,80,78,76,75},
new int[] {52,54,55,56,59},
new int[] {83,82,80,77,76,74,73},
new int[] {81,79,77,74,72,71,68,67},
new int[] {80,81,83,84,87},
new int[] {11,13,16,18,21,24,25},
new int[] {42,40,39,37,35,34},
new int[] {19,18,16,14,13,12,9},
new int[] {89,87,85,84,81},
new int[] {91,90,88,86,83},
new int[] {85,82,80,77,76,74,71,70},
new int[] {52,54,57,59,62},
new int[] {2,4,7,8,10},
new int[] {61,64,66,67,68,71,73},
new int[] {29,30,33,36,38,39,41},
new int[] {58,57,54,52,51,49},
new int[] {83,84,85,87,89,91},
new int[] {23,22,19,16,14,13,11},
new int[] {41,42,44,45,48,51,52,53},
new int[] {32,30,28,26,23,20,17},
new int[] {72,73,75,76,77},
new int[] {78,75,74,71,68,65},
new int[] {87,88,89,91,93,95},
new int[] {81,84,85,86,89,91},
new int[] {26,25,24,22,19,18,16},
new int[] {44,42,40,39,36,34},
new int[] {63,65,67,69,72,73},
new int[] {48,51,53,56,58,61,64},
new int[] {95,93,90,87,84,82,79,77},
new int[] {45,46,49,52,54,55},
new int[] {36,33,30,28,27,24},
new int[] {4,6,7,9,12,15},
new int[] {20,19,17,14,13,10,9,7},
new int[] {6,8,11,12,14},
new int[] {52,53,55,57,58,61,64,67},
new int[] {58,55,54,52,50,49},
new int[] {89,88,85,83,82},
new int[] {15,12,11,10,9},
new int[] {30,29,27,25,22,20,19,16},
new int[] {63,65,66,67,70},
new int[] {62,60,57,55,54,51,49},
new int[] {49,48,47,45,44,42,40},
new int[] {91,88,86,83,80,77,75},
new int[] {54,57,59,60,63,65},
new int[] {89,92,94,95,97},
new int[] {6,9,11,12,15,16},
new int[] {91,89,87,86,84,83,82},
new int[] {41,42,43,44,46,47,48,49},
new int[] {40,37,34,33,30,29},
new int[] {36,39,40,43,44,46},
new int[] {53,55,58,59,60,63,66},
new int[] {69,70,73,74,76,77},
new int[] {59,60,61,63,64,66,69,70},
new int[] {12,13,15,16,19,22,23},
new int[] {94,93,92,90,89,88,87,86},
new int[] {1,4,7,10,13,15,18},
new int[] {44,42,40,38,35,34,31,28},
new int[] {99,98,96,94,93},
new int[] {7,9,10,13,16,19,20,22},
new int[] {80,79,76,75,74},
new int[] {79,81,83,84,87,88},
new int[] {76,73,72,70,68,67,64},
new int[] {81,84,85,86,87,89,92,93},
new int[] {53,55,56,58,59,62,64,65},
new int[] {75,74,72,71,70,68},
new int[] {33,30,28,25,22,20,17},
new int[] {36,33,30,27,24,22},
new int[] {76,77,78,80,81,84,87},
new int[] {72,69,68,66,64,62},
new int[] {33,35,38,39,42},
new int[] {53,56,59,60,62,63,65},
new int[] {46,47,48,51,53},
new int[] {16,17,19,20,23,25,28},
new int[] {74,76,79,82,84},
new int[] {29,26,23,20,18,16,14,12},
new int[] {66,69,72,74,75,76},
new int[] {32,34,36,38,41,44},
new int[] {46,44,41,39,38},
new int[] {59,60,61,62,64,67,68,71},
new int[] {38,40,42,43,46},
new int[] {45,43,42,39,38,35,32,30},
new int[] {56,59,61,64,66,69,70,71},
new int[] {2,5,7,10,11},
new int[] {64,63,62,61,58,57},
new int[] {46,44,41,39,38,37,35,32},
new int[] {32,31,29,26,23,21},
new int[] {97,96,94,91,89,88,85},
new int[] {54,52,50,47,44,43,41,39},
new int[] {20,18,15,14,12,10,9},
new int[] {33,35,36,38,39,42,45,46},
new int[] {15,17,19,21,24,25,26,27},
new int[] {85,87,88,90,91,92},
new int[] {61,58,57,54,51,48,46,45},
new int[] {47,48,49,52,54},
new int[] {29,27,24,23,20,19,18,16},
new int[] {22,20,18,17,16,15,14,12},
new int[] {65,66,67,69,71,74,76,77},
new int[] {19,18,15,13,12,9,6},
new int[] {25,22,19,17,15,14,12,9},
new int[] {20,23,24,26,29},
new int[] {35,36,39,41,43,45},
new int[] {34,32,29,28,26},
new int[] {15,18,19,20,21,22,23},
new int[] {43,46,48,49,51},
new int[] {84,82,81,79,77},
new int[] {47,49,50,53,56,59},
new int[] {22,19,18,17,14,12,11,8},
new int[] {84,82,79,76,73,70,68},
new int[] {51,48,46,43,41,39,37,36},
new int[] {19,21,23,24,27,28,31},
new int[] {60,58,55,54,51,49},
new int[] {76,73,71,70,68,67},
new int[] {18,15,13,11,10,7,5,3},
new int[] {97,95,93,92,90},
new int[] {46,47,49,52,55},
new int[] {92,90,87,86,85,82},
new int[] {80,81,83,84,86,88,90,92},
new int[] {28,31,33,34,36,39},
new int[] {44,47,50,52,55,57,60},
new int[] {14,15,16,17,20},
new int[] {99,97,96,93,90},
new int[] {48,51,53,54,56,57,58,61},
new int[] {86,87,90,91,94,97},
new int[] {81,80,79,78,77,74},
new int[] {62,63,66,68,69,72,75},
new int[] {95,94,91,88,85,82},
new int[] {40,39,37,36,33,31},
new int[] {36,38,40,42,45},
new int[] {71,69,66,63,60,59},
new int[] {69,70,71,73,76},
new int[] {71,74,75,76,79,80,82,85},
new int[] {77,78,81,82,83,85,87},
new int[] {14,11,9,6,5,2},
new int[] {38,36,35,34,31,30},
new int[] {71,69,66,63,60},
new int[] {77,78,79,81,82},
new int[] {23,22,19,16,14,11,10,8},
new int[] {75,77,80,83,84,87,88},
new int[] {64,65,67,69,71,74,75,77},
new int[] {88,87,86,84,81,80,77,75},
new int[] {48,47,44,41,40},
new int[] {75,77,80,83,86,87,88,90},
new int[] {34,35,38,39,41},
new int[] {81,80,78,75,72,69},
new int[] {62,61,60,58,56},
new int[] {25,27,28,30,31},
new int[] {50,47,45,43,42,39},
new int[] {10,12,15,16,17,19,22,24},
new int[] {50,51,52,54,56,57,59},
new int[] {44,41,40,37,36,34,32},
new int[] {76,73,70,67,66,64,63},
new int[] {91,88,85,82,79,76,75,74},
new int[] {81,82,84,86,88,91,92},
new int[] {17,14,12,9,8,7,5},
new int[] {24,23,21,19,16,13,10},
new int[] {78,76,74,71,69,66},
new int[] {61,63,66,68,71,72,73,75},
new int[] {93,91,89,88,87,84},
new int[] {23,25,27,30,31,33,36,38},
new int[] {35,36,37,40,41,43,44,47},
new int[] {81,84,85,86,89,91,93,95},
new int[] {89,92,93,94,95},
new int[] {37,38,39,42,45,46,48,51},
new int[] {38,35,33,31,28,25,24,23},
new int[] {38,36,34,32,31,30,28},
new int[] {2,4,5,7,10,13,15,17},
new int[] {23,26,29,32,34,35},
new int[] {18,17,15,13,12,10,7},
new int[] {51,48,45,42,40},
new int[] {15,16,19,20,23,26,27},
};
    static bool checkMatrix(int[][] matrix)
    {
        int safe = 0;

        foreach (int[] row in matrix)
        {
            if (row.Equals(row.OrderByDescending(x => x)))
            {
                for (int i = 0; i < row.Length; i++)
                {
                    if (Math.Abs(row[i] - row[i + 1]) > 3)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                    while (i == row.Length)
                    {
                        if (true)
                        {
                            safe++;
                        }
                    }
                }
            }
            else if (row.Equals(row.OrderBy(x => x)))
            {
                for (int i = 0; i < row.Length; i++)
                {
                    if (Math.Abs(row[i] - row[i + 1]) > 3)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                    while (i == row.Length)
                    {
                        if (true)
                        {
                            safe++;
                        }
                    }
                }
            }
            else
            {
                return false;
            }
        }
    }
checkMatrix(matrix);
Console.WriteLine(safe);
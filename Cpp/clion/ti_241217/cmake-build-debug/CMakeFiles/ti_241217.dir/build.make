# CMAKE generated file: DO NOT EDIT!
# Generated by "Unix Makefiles" Generator, CMake Version 3.31

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:

#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:

# Disable VCS-based implicit rules.
% : %,v

# Disable VCS-based implicit rules.
% : RCS/%

# Disable VCS-based implicit rules.
% : RCS/%,v

# Disable VCS-based implicit rules.
% : SCCS/s.%

# Disable VCS-based implicit rules.
% : s.%

.SUFFIXES: .hpux_make_needs_suffix_list

# Command-line flag to silence nested $(MAKE).
$(VERBOSE)MAKESILENT = -s

#Suppress display of executed commands.
$(VERBOSE).SILENT:

# A target that is always out of date.
cmake_force:
.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

# The shell in which to execute make rules.
SHELL = /bin/sh

# The CMake executable.
CMAKE_COMMAND = /usr/bin/cmake

# The command to remove a file.
RM = /usr/bin/cmake -E rm -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = /mnt/c/Dev/Cpp/clion/ti_241217

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = /mnt/c/Dev/Cpp/clion/ti_241217/cmake-build-debug

# Include any dependencies generated for this target.
include CMakeFiles/ti_241217.dir/depend.make
# Include any dependencies generated by the compiler for this target.
include CMakeFiles/ti_241217.dir/compiler_depend.make

# Include the progress variables for this target.
include CMakeFiles/ti_241217.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/ti_241217.dir/flags.make

CMakeFiles/ti_241217.dir/codegen:
.PHONY : CMakeFiles/ti_241217.dir/codegen

CMakeFiles/ti_241217.dir/main.cpp.o: CMakeFiles/ti_241217.dir/flags.make
CMakeFiles/ti_241217.dir/main.cpp.o: /mnt/c/Dev/Cpp/clion/ti_241217/main.cpp
CMakeFiles/ti_241217.dir/main.cpp.o: CMakeFiles/ti_241217.dir/compiler_depend.ts
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green --progress-dir=/mnt/c/Dev/Cpp/clion/ti_241217/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/ti_241217.dir/main.cpp.o"
	/usr/sbin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -MD -MT CMakeFiles/ti_241217.dir/main.cpp.o -MF CMakeFiles/ti_241217.dir/main.cpp.o.d -o CMakeFiles/ti_241217.dir/main.cpp.o -c /mnt/c/Dev/Cpp/clion/ti_241217/main.cpp

CMakeFiles/ti_241217.dir/main.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green "Preprocessing CXX source to CMakeFiles/ti_241217.dir/main.cpp.i"
	/usr/sbin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /mnt/c/Dev/Cpp/clion/ti_241217/main.cpp > CMakeFiles/ti_241217.dir/main.cpp.i

CMakeFiles/ti_241217.dir/main.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green "Compiling CXX source to assembly CMakeFiles/ti_241217.dir/main.cpp.s"
	/usr/sbin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /mnt/c/Dev/Cpp/clion/ti_241217/main.cpp -o CMakeFiles/ti_241217.dir/main.cpp.s

# Object files for target ti_241217
ti_241217_OBJECTS = \
"CMakeFiles/ti_241217.dir/main.cpp.o"

# External object files for target ti_241217
ti_241217_EXTERNAL_OBJECTS =

ti_241217: CMakeFiles/ti_241217.dir/main.cpp.o
ti_241217: CMakeFiles/ti_241217.dir/build.make
ti_241217: CMakeFiles/ti_241217.dir/compiler_depend.ts
ti_241217: CMakeFiles/ti_241217.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color "--switch=$(COLOR)" --green --bold --progress-dir=/mnt/c/Dev/Cpp/clion/ti_241217/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking CXX executable ti_241217"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles/ti_241217.dir/link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/ti_241217.dir/build: ti_241217
.PHONY : CMakeFiles/ti_241217.dir/build

CMakeFiles/ti_241217.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles/ti_241217.dir/cmake_clean.cmake
.PHONY : CMakeFiles/ti_241217.dir/clean

CMakeFiles/ti_241217.dir/depend:
	cd /mnt/c/Dev/Cpp/clion/ti_241217/cmake-build-debug && $(CMAKE_COMMAND) -E cmake_depends "Unix Makefiles" /mnt/c/Dev/Cpp/clion/ti_241217 /mnt/c/Dev/Cpp/clion/ti_241217 /mnt/c/Dev/Cpp/clion/ti_241217/cmake-build-debug /mnt/c/Dev/Cpp/clion/ti_241217/cmake-build-debug /mnt/c/Dev/Cpp/clion/ti_241217/cmake-build-debug/CMakeFiles/ti_241217.dir/DependInfo.cmake "--color=$(COLOR)"
.PHONY : CMakeFiles/ti_241217.dir/depend


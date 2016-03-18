/// <binding ProjectOpened='default' />
module.exports = function (grunt) {
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks('grunt-contrib-sass');
    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-contrib-clean');

    grunt.initConfig({
        uglify: {
            app: {
                files: { 'wwwroot/dist/app.js': ['Assets/todo.module.js', 'Assets/**/*.js'] }
            }
        },
        sass: {
            app: {
                files: { 'wwwroot/dist/app.css': ['Assets/app/todo.styles.scss'] }
            }
        },
        clean: {
           assets: ['wwwroot/assets']
        },
        copy: {
          dev: {
              src: 'assets/**',
              dest: 'wwwroot/'
          }
        },
        watch: {
            scripts: {
                files: ['Assets/**/*.js'],
                tasks: ['uglify']
            },
            css: {
                files: ['Assets/**/*.scss'],
                tasks: ['sass']
            },
            html: {
                files: ['Assets/**/*.htm'],
                tasks: ['copy']
            }
        }
    });

    grunt.registerTask('default', ['clean', 'copy', 'uglify', 'sass', 'copy', 'watch']);
};
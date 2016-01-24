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
                files: { 'wwwroot/app/app.js': ['Assets/app/todo.module.js', 'Assets/**/*.js'] }
            }
        },
        sass: {
            app: {
                files: { 'wwwroot/app/app.css': ['Assets/app/todo.styles.scss'] }
            }
        },
        clean: {
           app: ['wwwroot/app']
        },
        copy: {
          html: {
              src: 'Assets/app/todo.template.htm',
              dest: 'wwwroot/app/todo.template.htm'
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

    grunt.registerTask('default', ['clean', 'uglify', 'sass', 'copy', 'watch']);
};
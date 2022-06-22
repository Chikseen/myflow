const { defineConfig } = require("@vue/cli-service");
module.exports = defineConfig({
  transpileDependencies: true,
});

module.exports = {
  devServer: {
    https: true,
  },
  css: {
    loaderOptions: {
      sass: {
        additionalData: `
          @import "@/assets/_global.scss";
        `,
      },
    },
  },
};

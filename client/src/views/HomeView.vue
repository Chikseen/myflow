<template>
  <div class="home">
    <img alt="Vue logo" src="../assets/logo.png" />
    <button @click="getPizza">Pizza Get</button>
    <a :href="googleUrl">Google Login</a>
  </div>
</template>

<script>
import api from "@/apiService.js";

export default {
  name: "HomeView",
  components: {},
  computed: {
    googleUrl() {
      return `https://accounts.google.com/o/oauth2/v2/auth?client_id=${process.env.VUE_APP_GOOGLE_CLIENT_ID}&redirect_uri=${process.env.VUE_APP_GOOGLE_REDIRECT}&response_type=code&scope=email profile`;
    },
  },
  methods: {
    async getPizza() {
      console.log(await api.post("User", { Name: "hi" }));
    },
  },
};
</script>

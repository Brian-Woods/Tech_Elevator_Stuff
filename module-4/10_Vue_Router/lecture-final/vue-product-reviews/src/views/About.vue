<template>
  <div class="about">
    <katie-special />
    <h1> About the Author</h1>
    <author-bio />
  </div>
</template>

<script>
import AuthorBio from "@/components/AuthorBio.vue"
import KatieSpecial from "@/components/KatieSpecial.vue"

export default {
  name: "about",
  components: {
    AuthorBio,
    KatieSpecial
  }

}
</script>

<style>
.about {
  margin-top: 20px;
}
</style>